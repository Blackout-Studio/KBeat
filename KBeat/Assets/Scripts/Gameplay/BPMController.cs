using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

//Autor - Matyáš Himmer
public class BPMController : MonoBehaviour
{

    

    public void start()
    {

        Song[] songs = FindObjectOfType<AudioManager>().songs;

        Song pickedSong = songs[0];

        float BPS = 60.00f / pickedSong.bpm; // kolik sekund na jeden beat
        float sleepTime = BPS;


        StartCoroutine(Beats(sleepTime, pickedSong));
    }


    

    private IEnumerator Beats(float sleepTime, Song pickedSong)
    {
        yield return new WaitForSeconds(3);

        FindObjectOfType<AudioManager>().Play("Cradles");

        for (int i = 0; i <= pickedSong.bpm; i++)
        {

            FindObjectOfType<StartSpawning>().spawnOnBeat();
            Debug.Log("Tik");
            yield return new WaitForSeconds(sleepTime);
        }
    }



}
