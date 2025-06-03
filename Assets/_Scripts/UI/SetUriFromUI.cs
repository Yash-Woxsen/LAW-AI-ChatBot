using _Scripts.SERVER;
using TMPro;
using UnityEngine;

public class SetUriFromUI : MonoBehaviour
{
    public WebServer webServer;
    public TMP_InputField serverUriTextField;
    public TMP_InputField whisperUriTextField;
    public GameObject panel;

    public void SetUri()
    {
        webServer.textResponseUrl = serverUriTextField.text;
        webServer.serverUrl = whisperUriTextField.text;
    }

    public void TogglePanel()
    {
        panel.SetActive(!panel.activeInHierarchy);
    }
    
}
