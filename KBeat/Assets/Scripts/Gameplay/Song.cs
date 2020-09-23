using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

//Autor - Matyáš Himmer
[System.Serializable]
public class Song
{

    public float bpm;
    public AudioClip clip;
    public string name;
    public float length;
    [Min(1)]
    public int reactionTime;


    [Range(0f, 1f)]
    public float volume;
    [Range(.1f, 3f)]
    public float pitch;

    [HideInInspector]
    public AudioSource source;

    public Song(float bpm)
    {
        this.bpm = bpm;
    }
}