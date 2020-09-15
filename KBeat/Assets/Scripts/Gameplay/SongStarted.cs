using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Autor - Matyáš Himmer
public class SongStarted : MonoBehaviour
{

    public BPMController bpm;
    // Start is called before the first frame update
    void Start()
    {
        // call funkce StartCalculating
        bpm.StartCalculating();
    }

    public void start() 
    {
        bpm.StartCalculating();
    }
}
