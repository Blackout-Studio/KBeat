using UnityEngine;
using System.Threading;

public class BPMTimer : MonoBehaviour
{
   public void startCalculating()
    {

        Song song = new Song(120.00f);

        float BPS = 60.00f / song.bpm; // kolik sekund na jeden beat
        float sleepTime = BPS * 1000.00f;

        for (int i = 0; i <= song.bpm; i++)
        {
            Debug.Log("tik");

            Thread.Sleep((int)sleepTime);
        }
    }
        

  
}
