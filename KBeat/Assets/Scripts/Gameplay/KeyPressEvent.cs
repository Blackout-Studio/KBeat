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
        foreach (Note n in notes) 
        {
            n.isPressed(kcode, Time.time * 1000);
        }
    }

    public void addNote() 
    {
        Note note = new Note();
        Instantiate(noteObj);
    }
}
