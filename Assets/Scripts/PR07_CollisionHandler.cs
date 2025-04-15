using UnityEngine;

public class PR07_CollisionHandler : MonoBehaviour
{
    public GameObject spawnPrefab;
    public AudioSource audioSource;

    private void OnCollisionEnter(Collision collision)
    {
        // Spawn object at collision point
        ContactPoint contact = collision.contacts[0];
        Vector3 spawnPos = contact.point;
        Instantiate(spawnPrefab, spawnPos, Quaternion.identity);

        // Play sound
        if (audioSource != null)
        {
            audioSource.Play();
        }

        Debug.Log("Collision happened and event triggered.");
    }
}
