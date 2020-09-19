using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Autor - Milan Savickij
public class KeyPressEvent : MonoBehaviour
{

    public List<Note> notes = new List<Note>();
    private GameObject noteObj;

    public void keyPressed(KeyCode kcode)
    {
        double time = Time.time * 1000;
        foreach (Note n in notes) 
        {
            //n.isPressed(kcode, time);
        }
    }

    public void addNote(Note n) 
    {
        notes.Add(n);
    }
}
