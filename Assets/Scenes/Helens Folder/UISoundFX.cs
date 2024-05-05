using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISoundFX : MonoBehaviour
{
    AudioSource[] audios;
    AudioSource hoverAudio;
    AudioSource selectAudio;

    private void Start()
    {
        audios = GetComponents<AudioSource>();
        hoverAudio = audios[0];
        selectAudio = audios[1];
    }


    public void Hover()
    {
        hoverAudio.Play();
    }
    public void Select()
    {
        selectAudio.Play();
    }
}
