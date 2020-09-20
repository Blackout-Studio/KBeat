using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Autor - Matyáš Himmer

public class ScoreManager : MonoBehaviour
{
    public int score;
    //public int combo;
    private int comboMultiplier;

   public void addScore(int combo) {
       /* switch (comboMultiplier)
       {
            case combo >= 10 && combo <= 20: 
                comboMultiplier = 1.1f;
            case combo >= 21 && combo <= 30:
                comboMultiplier = 1.2f;
            case combo >= 21 && combo <= 30:
                comboMultiplier = 1.2f;
            case combo >= 31 && combo <= 40:
                comboMultiplier = 1.3f;
            case combo >= 41 && combo <= 50:
                comboMultiplier = 1.4f;
            case combo >= 51 && combo <= 60:
                comboMultiplier = 1.5f;
            case combo >= 61 && combo <= 70:
                comboMultiplier = 1.6f;
           default:
           comboMultiplier = 1.0f;
       } */

       if (combo >= 10 && combo <= 20) {
           comboMultiplier = 2;
       } else if (combo >= 21 && combo <= 30) {
           comboMultiplier = 3;
       } else if (combo >= 31 && combo <= 40) {
           comboMultiplier = 4;
       } else if (combo >= 41 && combo <= 50) {
           comboMultiplier = 5;
       } else if (combo >= 51 && combo <= 60) {
           comboMultiplier = 6;
       } else if (combo >= 61 && combo <= 100) {
            comboMultiplier = 7;
       } else if (combo >= 101 && combo <= 200) {
           comboMultiplier = 8;
       } else if (combo >= 201 && combo <= 400) {
           comboMultiplier = 9;
       } else {
           comboMultiplier = 1;
       }

       
       
       score += 1 * comboMultiplier;
   }
}
