using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ButtonSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    public void playClip()
    {
        audioSource.clip = audioClip;
        audioSource.Play();

    }
}
