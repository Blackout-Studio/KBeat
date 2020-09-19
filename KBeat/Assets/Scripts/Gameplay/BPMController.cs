using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

//Autor - Matyáš Himmer
public class BPMController : MonoBehaviour
{
    public AudioManager amanager;
    public StartSpawning spawnStart;

    private int reactionTime;
    public void Start()
    {
        

        Song[] songs = amanager.songs;

        Song pickedSong = songs[amanager.song];
        reactionTime = pickedSong.reactionTime;

        float BPS = 60.00f / pickedSong.bpm; // kolik sekund na jeden beat
        spawnStart.cooldown = (double)BPS;
        float sleepTime = BPS;


        StartCoroutine(Beats(sleepTime, pickedSong, BPS));
    }


    

    private IEnumerator Beats(float sleepTime, Song pickedSong, float BPS)
    {
        yield return new WaitForSeconds(3);

        amanager.Play(pickedSong.name);
        Debug.Log(pickedSong.bpm * pickedSong.length);
        

        for (int i = 0; i <= pickedSong.bpm * pickedSong.length; i++)
        {
            float randomNum = Random.Range( 0.0f,  10.0f);

            sleepTime = BPS;

            if (randomNum <= 5.0f)
            {
                sleepTime *= 1.0f;
            } else
            {
                sleepTime *= 2.0f;
            }
            spawnStart.spawnOnBeat(reactionTime);
            //print(sleepTime);
            yield return new WaitForSeconds(sleepTime);
        }
    }



}
