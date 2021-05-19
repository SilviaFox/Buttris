using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFunctions : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void StartStandard()
    {
        FindObjectOfType<PresetSettings>().SetStandardSettings();
    }

    public void StartClassic()
    {
        FindObjectOfType<PresetSettings>().SetClassicSettings();
    }
}
