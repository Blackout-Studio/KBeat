using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Author S.H.

public class IntroHandler : MonoBehaviour
{
    public VideoPlayer VideoPlayer;
    public Text TestText;
    public bool VideoStarted = false;
    private int FrameCount = 0;
    private bool VideoFinished = false;

    // Update is called once per frame
    void Update()
    {
        if (VideoStarted == false && VideoPlayer.isPlaying == false && FrameCount < 60 && !VideoFinished)
        {
            VideoStarted = true;
        }
        if (VideoStarted == true && VideoPlayer.isPlaying == false && FrameCount >= 60 && !VideoFinished)
        {
            SceneManager.LoadScene("Menu");
        }
        if (!VideoFinished)
        {
            FrameCount++;
        }
    }
    
}
