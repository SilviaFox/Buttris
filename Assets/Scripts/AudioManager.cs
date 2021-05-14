using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{
    [SerializeField] Sound[] sounds;
    [SerializeField] Sound[] music;
    [SerializeField] AudioMixerGroup soundMixer;
    [SerializeField] AudioMixerGroup musicMixer;

    [HideInInspector] public float currentSongTime;
    Sound lastSong;

    public static AudioManager instance = null;

    void Start() // Initialize all Audio Sources
    {
        if (instance == null)
            instance = this;

        DontDestroyOnLoad(this.gameObject);

        foreach (Sound s in sounds)
        {
            s.source = this.gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
            s.source.outputAudioMixerGroup = soundMixer;

            if (s.playOnAwake)
                Play(s.name);
        }

        foreach (Sound s in music)
        {
            s.source = this.gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
            s.source.outputAudioMixerGroup = musicMixer;

            if (s.playOnAwake)
                PlayMusic(s.name);
        }

    }

    private void Update()
    {
        if (lastSong != null)
            currentSongTime = lastSong.source.time;
    }

    public void Play(string name) // Find a source with the same name and play the sound
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null) // stops errors from occuring from typos
        {
            Debug.LogWarning("Sound: " + name + "not found!");
            return;
        }
        
        s.source.Play();
    }

    public void PlayMusic(string name, float timeToPlay = 0) // Find a source with the same name and play the sound
    {
        if (lastSong != null)
            lastSong.source.Stop();

        Sound s = Array.Find(music, song => song.name == name);
        if (s == null) // stops errors from occuring from typos
        {
            Debug.LogWarning("Sound: " + name + "not found!");
            return;
        }
        
        s.source.Play();
        s.source.time = timeToPlay;
        lastSong = s;
    }

    

    public void Stop(string name) // Find a source with the same name and stop the sound
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null) // stops errors from occuring from typos
        {
            Debug.LogWarning("Sound: " + name + "not found!");
            return;
        }
        
        s.source.Stop();
    }

    public void StopMusic() // Find a source with the same name and stop the sound
    {
        lastSong.source.Stop();
        lastSong = null;
    }
}
