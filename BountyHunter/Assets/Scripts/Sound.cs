using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound 
{
    public string name;

    public AudioClip clip;

    // Sliders for the volume and the pitch
    [Range(0f,1f)]
    public float volume;
    [Range(0.1f,3f)]
    public float pitch;

    // Toggle that loops the sound
    public bool loop;

    [HideInInspector]
    public AudioSource source;
}
