using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//Autor - Milan Savickij
public class KeyTyping : MonoBehaviour
{

    private int[] values;
    private bool[] keys;

    void Awake()
    {
        values = (int[])System.Enum.GetValues(typeof(KeyCode));
        keys = new bool[values.Length];
    }

    void Update()
    {
        if (Input.anyKeyDown()) {
            for (int i = 0; i < values.Length; i++)
            {
                keys[i] = Input.GetKey((KeyCode)values[i]);
            }
        }
    }

    void checkForKey() 
    {
    
    }
}
