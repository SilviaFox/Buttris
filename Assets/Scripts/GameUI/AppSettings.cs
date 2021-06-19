using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class AppSettings : MonoBehaviour
{
    [SerializeField] AudioMixer soundMixer;
    [SerializeField] Slider soundSlider, musicSlider;
    [SerializeField] Toggle rotationLock;
    [SerializeField] Slider repeatDelay;
    [SerializeField] Text repeatDelayText;

    private void Awake()
    {
        soundSlider.value = PlayerPrefs.GetFloat("SoundVolume", soundSlider.maxValue);
        musicSlider.value = PlayerPrefs.GetFloat("MusicVolume", musicSlider.maxValue);

        rotationLock.isOn = PlayerPrefs.GetInt("LockRotationSprite", 1) == 1? true : false;
        repeatDelay.value = PlayerPrefs.GetFloat("RepeatDelay", 0.1f);
        repeatDelayText.text = "DAS Repeat Delay (" + repeatDelay.value + ")";

        // soundMixer.SetFloat("soundVol", soundSlider.value);
        // soundMixer.SetFloat("musicVol", musicSlider.value);
    }

    public void SetSoundVolume(float soundLevel)
    {
        soundMixer.SetFloat("soundVol", soundLevel);
        PlayerPrefs.SetFloat("SoundVolume", soundLevel);
        Debug.Log(soundLevel);
    }

    public void SetMusicVolume(float soundLevel)
    {
        soundMixer.SetFloat("musicVol", soundLevel);
        PlayerPrefs.SetFloat("MusicVolume", soundLevel);
        Debug.Log(soundLevel);
    }
    
    public void SetRotationSpriteLock(bool toggle)
    {
        GameSettings.lockRotationSprite = toggle;
        PlayerPrefs.SetInt("LockRotationSprite", toggle? 1 : 0);
    }

    public void SetDASRepeatSpeed(float speed)
    {
        speed = ((float)System.Math.Round(speed, 2));

        repeatDelay.value = speed;
        GameSettings.dASRepeatSpeed = speed;
        PlayerPrefs.SetFloat("RepeatDelay", speed);
        repeatDelayText.text = "DAS Repeat Delay (" + speed + ")";
    }
}
