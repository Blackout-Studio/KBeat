using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInEffect : MonoBehaviour

{
    public Image BlackImage;

    public void FadeOut()
    {
        StartCoroutine(FadeImage(true));
    }

    void Start()
    {
        FadeOut();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator FadeImage(bool FadeAway)
    {
        yield return new WaitForSeconds(1.5f);
        if (FadeAway)
        {
            for (float i = 1; i >= 0; i -= Time.deltaTime)
            {
                BlackImage.color = new Color(0, 0, 0, i);
                yield return new WaitForSeconds(0.01f);
            }
        }
    }
}
