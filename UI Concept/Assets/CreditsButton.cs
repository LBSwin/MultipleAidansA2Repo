using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsButton : MonoBehaviour
{
    public void CreditsSceneButton()
    {
        SceneManager.LoadScene("Credits Scene");
    }
}
