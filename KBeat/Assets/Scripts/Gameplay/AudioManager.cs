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

    public void Stop (string name)
    {
        Song s = Array.Find(songs, song => song.name == name);

        StartCoroutine(Stop(s));
        
    }

    void Start()
    {
        //Play("IWantItThatWay");
        
    }

    private IEnumerator Stop(Song s)
    {
        for (float i = s.source.volume; i >= 0; i -= 0.01f)
        {
            s.source.volume = i;
            
            yield return new WaitForSeconds(0.1f);
        }
        s.source.Stop();
    }
}
