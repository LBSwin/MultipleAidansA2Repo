using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsButton : MonoBehaviour
{
    public void OptionsSceneButton()
    {
        SceneManager.LoadScene("Options Scene");
    }
}
