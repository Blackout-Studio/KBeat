using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

//Autor - Matyáš Himmer
public class LevelLoaded : MonoBehaviour
{

   


    void Start()
    {

        StartCoroutine(StartPlaying());
        
    }

    private IEnumerator StartPlaying()
    {
        yield return new WaitForSeconds(2);
        FindObjectOfType<AudioManager>().Play("Cradles");
    }


}
