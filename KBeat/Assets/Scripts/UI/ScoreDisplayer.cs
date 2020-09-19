using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Autor S.H.

public class ScoreDisplayer : MonoBehaviour
{

    public ScoreManager scoreManager;
    public Text ScoreText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = scoreManager.score.ToString();
        Debug.Log(scoreManager.score);
    }
}
