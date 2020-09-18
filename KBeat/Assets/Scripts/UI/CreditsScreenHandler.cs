using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsScreenHandler : MonoBehaviour
{
    public Text CreditsText;
    public TextAsset CreditsFile;
    public bool Sliding = false;
    float speed = 0.8f;

    // Start is called before the first frame update
    void Start()
    {
        //var Credits = "KBeat\nBlackout Studio 2020\n";
        //Credits += "hey\n";
        //Credits += "lool\n";
        //CreditsText.text = Credits;
        CreditsText.text = CreditsFile.text;
        StartSliding();
    }

    void StartSliding()
    {
        Sliding = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (!Sliding)
            return;
        Vector3 pos = CreditsText.transform.position;
        pos.y += speed;
        CreditsText.transform.position = pos;
    }
}
