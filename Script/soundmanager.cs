using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class soundmanager : MonoBehaviour
{

    [SerializeField] private AudioMixer mixxer;
    [SerializeField] private Slider audioslider;


    public void setVolume()
    {
        float volume = audioslider.value;
        mixxer.SetFloat("music", Mathf.Log10(volume)*20);
    }
}
