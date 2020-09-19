using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Autor Matyáš Himmer

public class ScoreManager : MonoBehaviour
{
    public int score;
    public float combo;

   public void addScore() {
       score += 1;
       Debug.Log(score);
   }
}
