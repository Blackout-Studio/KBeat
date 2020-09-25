using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Autor - Milan Savickij
public class KeyPressEvent : MonoBehaviour
{

    public List<Note> notes = new List<Note>();
    private GameObject noteObj;

    public int currentCombo = 0;
    
    public ScoreManager scoreManager;
    public void keyPressed(KeyCode kcode)
    {
        double time = Time.time * 1000;
        bool pressed = false;
        foreach (Note n in notes) 
        {
            //n.isPressed(kcode, time);
            if(n != null && !pressed)
            {
                if(n.timeLeft > -0.15f && kcode == n.key)
                {
                    Destroy(n.gameObject);
                    // adds score
                    currentCombo += 1;
                    scoreManager.addScore(combo: currentCombo);
                    
                    pressed = true;
                }
            }
        }
    }

    public void addNote(Note n) 
    {
        notes.Add(n);
    }
}
