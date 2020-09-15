using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSpawning : MonoBehaviour
{

    public GameObject cube;

    

    public void spawnOnBeat()
    {
        
        Instantiate(cube);
        
    }

   
}
