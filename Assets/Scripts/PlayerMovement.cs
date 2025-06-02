using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(Collider))]
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    public int maxJumps = 2;
    public LayerMask groundLayer;
    public float groundCheckOffset = 0.1f;

    private Rigidbody rb;
    private int jumpCount;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        isGrounded = IsGrounded();

        if (isGrounded)
            jumpCount = 0;

        if (Input.GetButtonDown("Jump") && jumpCount < maxJumps)
        {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, jumpForce, rb.linearVelocity.z);
            jumpCount++;
        }

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 move = transform.TransformDirection(new Vector3(h, 0, v).normalized) * moveSpeed;
        rb.linearVelocity = new Vector3(move.x, rb.linearVelocity.y, move.z);
    }

    bool IsGrounded()
    {
        Collider col = GetComponent<Collider>();
        Vector3 center = col.bounds.center;
        Vector3 bottom = new Vector3(center.x, col.bounds.min.y - groundCheckOffset, center.z);
        return Physics.CheckCapsule(center, bottom, 0.2f, groundLayer);
    }
}
