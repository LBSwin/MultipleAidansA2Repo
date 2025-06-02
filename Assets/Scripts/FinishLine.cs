using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Level Complete!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // reload or go to next scene
        }
    }
}
