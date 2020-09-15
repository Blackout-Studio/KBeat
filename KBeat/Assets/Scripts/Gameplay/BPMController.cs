using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

//Autor - Matyáš Himmer

public class BPMTimer : MonoBehaviour
{

    public StartSpawning other;

    public void StartCalculating()
    {

        Song song = new Song(120.00f);

        float BPS = 60.00f / song.bpm; // kolik sekund na jeden beat
        float sleepTime = BPS * 1000.00f;

        for (int i = 0; i <= song.bpm; i++)
        {

            other.spawnOnBeat();
            Debug.Log("Tik");
            Thread.Sleep((int)sleepTime);
        }
    }
        

  
}
