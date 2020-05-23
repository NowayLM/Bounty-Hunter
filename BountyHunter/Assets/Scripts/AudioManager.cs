using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Creates an array of sounds for the AudioManager
    public Sound[] sounds;

    public static AudioManager instance;

    // Start is called before the first frame update
    void Awake()
    {
       // Commented because prevents to have the audiomanager in != scenes 
        /*
        if (instance == null)
        instance = this;
        else
        {
            // This avoids having 2 AudioManagers in the same scene
            Destroy(gameObject);
            return;
        }
        

        DontDestroyOnLoad(gameObject);
        */
        foreach(Sound sound in sounds)
        {
            sound.source = gameObject.AddComponent<AudioSource>();
            sound.source.clip = sound.clip;
            sound.source.volume = sound.volume;
            sound.source.pitch = sound.pitch;
            sound.source.loop = sound.loop;
        }
    }

    // Update is called once per frame
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.Log("The sound " + name + " does not exist!");
            return;
        }
        s.source.Play();
    }


}
