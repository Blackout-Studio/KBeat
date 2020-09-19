using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class CreditsScreenHandler : MonoBehaviour
{
    public Text CreditsText;
    public TextAsset CreditsFile;
    public Image BlackImage;
    public GameObject MainMenu;
    public GameObject CreditsFrame;

    public bool Sliding = false;
    float speed = 0.8f; 

    public void FadeIn()
    {
        StartCoroutine(FadeImage(true));
    }

    public void FadeOut()
    {
        StartCoroutine(FadeOutImage(true));
    }

    public void StartSliding()
    {
        Sliding = true;
        string word = File.ReadAllText("Assets/Texts/Credits.txt");
        CreditsText.text = word;
        BlackImage.color = new Color(0, 0, 0, 0);
        BlackImage.enabled = true;
        FadeIn();
        StartCoroutine(StopSliding());
        Debug.Log(CreditsText.transform.position.y);
    }

    // Start is called before the first frame update
    void Start()
    {
        //var Credits = "KBeat\nBlackout Studio 2020\n";
        //Credits += "hey\n";
        //Credits += "lool\n";
        //CreditsText.text = Credits;
        //Debug.Log("Starting");

    }

    // Update is called once per frame
    void Update()
    {
        if (!Sliding)
            return;
        Vector3 pos = CreditsText.transform.position;
        pos.y += speed;
        CreditsText.transform.position = pos;
        
        //if (CreditsText.transform.position.y > 2500)
        //{
          //  Sliding = false;
          //  FadeOut();
        //}
    }

    //Fade Function
    IEnumerator FadeImage(bool FadeAway)
    {
        Debug.Log("Start");
        yield return new WaitForSeconds(0.5f);
        if (FadeAway)
        {
            for (float i = 0; i <= 3; i += Time.deltaTime)
            {
                Debug.Log(i);
                BlackImage.color = new Color(0, 0, 0, i);
                yield return new WaitForSeconds(0.009f);
            }
        }
    }

    IEnumerator FadeOutImage(bool FadeAway)
    {
        yield return new WaitForSeconds(1.5f);
        if (FadeAway)
        {
            
            for (float i = 1; i >= 0; i -= Time.deltaTime)
            {
                BlackImage.color = new Color(0, 0, 0, i);
                yield return new WaitForSeconds(0.009f);
            }
            BlackImage.enabled = false;
            CreditsFrame.SetActive(false);
            Debug.Log(CreditsText.transform.position.y);
            Vector3 temp = new Vector3(0, -140.7f, 0);
            CreditsText.transform.position = new Vector3(CreditsText.transform.position.x, -140.7f, CreditsText.transform.position.z);
        }
    }

    IEnumerator StopSliding()
    {
        yield return new WaitForSeconds(28);
        Sliding = false;
        FadeOut();
    }
}
