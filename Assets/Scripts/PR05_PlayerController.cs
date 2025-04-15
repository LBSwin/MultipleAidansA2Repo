using UnityEngine;

public class PR05_PlayerController : MonoBehaviour
{
    public float moveForce = 10f;
    public float jumpForce = 7f;
    public float fallThreshold = -10f;
    public Vector3 startPosition;

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPosition = transform.position;
    }

    void Update()
    {
        // Jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        // Respawn if player falls
        if (transform.position.y < fallThreshold)
        {
            Respawn();
        }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 force = new Vector3(h, 0, v) * moveForce;
        rb.AddForce(force);
    }

    void Respawn()
    {
        rb.linearVelocity = Vector3.zero;
        transform.position = startPosition;
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}

