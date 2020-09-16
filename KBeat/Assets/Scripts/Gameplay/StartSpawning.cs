using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Autor - Matyáš Himmer

public class StartSpawning : MonoBehaviour
{

    public GameObject cube;

    

    public void spawnOnBeat()
    {

        FindObjectOfType<AudioManager>().Play("Cradles");
        
    }

   
}
