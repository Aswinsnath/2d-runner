using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Audio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip deathSound;

    public AudioSource audio;
    public AudioClip coinSound;

    public AudioSource checkpointaudio;
    public AudioClip checkpointSound;

    public AudioMixer audioMixer; // Audio Mixer variable

    public void death()
    {
        if (deathSound != null && audioSource != null)
        {
            audioSource.clip = deathSound;
            audioSource.Play();
            audioMixer.SetFloat("GameVolume", -10f); // adjust volume
        }
    }

    public void coin()
    {
        if (coinSound != null && audio != null)
        {
            audio.clip = coinSound;
            audio.Play();
            audioMixer.SetFloat("GameVolume", -10f); // adjust volume
        }
    }

    public void checkpoint()
    {
        if (checkpointSound != null && checkpointaudio != null)
        {
            checkpointaudio.clip = checkpointSound;
            checkpointaudio.Play();
            audioMixer.SetFloat("GameVolume", -10f); 
        }
    }
}
