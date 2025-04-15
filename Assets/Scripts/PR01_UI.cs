using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PR01_UI : MonoBehaviour
{
    public Button helloButton;
    public TMP_Text outputText;

    void Start()
    {
        helloButton.onClick.AddListener(OnHelloClicked);
    }

    void OnHelloClicked()
    {
        outputText.text = "You clicked the button!";
        Debug.Log("Button was clicked!");
    }
}
