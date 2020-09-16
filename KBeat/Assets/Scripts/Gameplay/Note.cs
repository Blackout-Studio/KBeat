using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Autor - Milan Savickij
public class Note : MonoBehaviour
{

    private double time;
    private double cooldown;
    private KeyCode key;

    //public int order;

    public Note(double time, double timeToHit, KeyCode kcode) 
    {
        this.time = time;
        this.cooldown = timeToHit;
        this.key = kcode;
    }

    public void isPressed(KeyCode kcode, double millis) 
    {
        if (millis-time < cooldown && key == kcode) 
        {
            Debug.Log("Note was sucessfully hit");
        }
    }
}
