using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class AppSettings : MonoBehaviour
{
    [SerializeField] AudioMixer soundMixer;
    [SerializeField] AudioMixer musicMixer;

    public void SetSoundVolume(float soundLevel)
    {
        soundMixer.SetFloat("soundVol", soundLevel);
        Debug.Log(soundLevel);
    }

    public void SetMusicVolume(float soundLevel)
    {
        soundMixer.SetFloat("musicVol", soundLevel);
        Debug.Log(soundLevel);
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }

    
}
