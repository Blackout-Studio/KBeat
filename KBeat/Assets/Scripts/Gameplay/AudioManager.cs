using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;
using System;

//Autor - Matyáš Himmer

public class AudioManager : MonoBehaviour
{

    public Song[] songs;

    void Awake()
    {
        foreach (Song s in songs)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    public void Play (string name)
    {
        Song s = Array.Find(songs, song => song.name == name);
        s.source.Play();
    }

    void Start()
    {
        //Play("IWantItThatWay");
        
    }
}
