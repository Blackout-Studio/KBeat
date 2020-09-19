using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

//Autor - Matyáš Himmer
public class BPMController : MonoBehaviour
{
    public AudioManager amanager;
    public StartSpawning spawnStart;

    public float universalOffset;

    public void Start()
    {
        

        Song[] songs = amanager.songs;

        Song pickedSong = songs[3];
        

        float BPS = 60.00f / pickedSong.bpm; // kolik sekund na jeden beat
        float sleepTime = BPS;
        spawnStart.cooldown = (double)BPS;


        StartCoroutine(Beats(sleepTime, pickedSong, BPS));
    }


    

    private IEnumerator Beats(float sleepTime, Song pickedSong, float BPS)
    {
        yield return new WaitForSeconds(3);

        amanager.Play(pickedSong.name);


        yield return new WaitForSeconds(universalOffset);
       // yield return new WaitForSeconds(BPS / 2.00f);

        for (int i = 0; i <= pickedSong.bpm; i++)
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
            spawnStart.spawnOnBeat();
            //print(sleepTime);
            yield return new WaitForSeconds(sleepTime);
        }
    }



}
