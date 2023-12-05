using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField] private ConfirmationWindow myConfirmationWindow;
    public string desc ="";
    // Start is called before the first frame update
    void Start()
    {
        OpenConfirmationWindow(desc);
    }

    public void OpenConfirmationWindow(string message)
    {
        myConfirmationWindow.gameObject.SetActive(true);
        myConfirmationWindow.yesButton.onClick.AddListener(YesClicked);
        myConfirmationWindow.messageText.text = message;
    }

    private void YesClicked()
    {
        myConfirmationWindow.gameObject.SetActive(false);
        Debug.Log("Yes Clicked");
    }
}
