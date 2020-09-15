using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Autor - Matyáš Himmer

public class Song : MonoBehaviour
{
    public float bpm;
    public string author;
    public int length;

    public Song(float bpm, string author, int length)
    {
        this.bpm = bpm;
        this.author = author;
        this.length = length;
    } 

    public Song(float bpm)
    {
        this.bpm = bpm;
    }
}