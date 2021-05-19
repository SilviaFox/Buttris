using UnityEngine;
using UnityEngine.InputSystem;

public class ActiveControllers : MonoBehaviour
{

    bool gamepadActive;

    private void Start()
    {
        if (Gamepad.current != null)
            gamepadActive = true;
    }

    private void FixedUpdate()
    {
        if (gamepadActive && Gamepad.current.wasUpdatedThisFrame)
            InputScript.inputDevice = InputScript.InputDevice.Controller;
        else if (Keyboard.current.wasUpdatedThisFrame)
            InputScript.inputDevice = InputScript.InputDevice.Keyboard;
    }
}
