using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{

    public void PlaySceneButton()
    {
        SceneManager.LoadScene("Play Scene");
    }


}
