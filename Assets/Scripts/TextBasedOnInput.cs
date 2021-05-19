using UnityEngine;
using UnityEngine.UI;

public class TextBasedOnInput : MonoBehaviour
{
    
    Text text;

    string keyboardText;
    [SerializeField] string controllerText;

    private void Awake()
    {
        text = GetComponent<Text>();
        keyboardText = text.text;
    }

    private void Update()
    {
        switch (InputScript.inputDevice)
        {
            case InputScript.InputDevice.Keyboard:
                text.text = keyboardText;
            break;

            case InputScript.InputDevice.Controller:
                text.text = controllerText;
            break;
        }
    }

}

