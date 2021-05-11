using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    [SerializeField] Sound[] sounds;

    void Start() // Initialize all Audio Sources
    {
        foreach (Sound s in sounds)
        {
            s.source = this.gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
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
}
