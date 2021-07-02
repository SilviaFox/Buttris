using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFunctions : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
    }

    public void Custom()
    {
        Transitions.instance.StartCoroutine(Transitions.instance.TransitionToNextScene(0.05f, "CustomMenu"));
    }

    public void StartStandard()
    {
        PresetSettings.instance.SetStandardSettings();
    }

    public void StartClassic()
    {
        PresetSettings.instance.SetClassicSettings();
    }
}
