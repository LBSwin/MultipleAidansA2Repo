using UnityEngine;
using UnityEngine.SceneManagement;

public class SampleSceneButton : MonoBehaviour
{
    public void SampleButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
