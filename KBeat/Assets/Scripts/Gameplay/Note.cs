using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Autor - Milan Savickij
public class Note : MonoBehaviour
{
    public double timeLeft;
    public KeyCode key;
    private float speed;


    public void Initialize(double timeToHit, KeyCode kcode, int reactionTime, Sprite image)
    {
        this.timeLeft = timeToHit*reactionTime;
        this.key = kcode;
        speed = (float)Mathf.Abs(this.gameObject.transform.position.z - 4)/(float)this.timeLeft;
        GameObject child = this.gameObject.transform.GetChild(0).gameObject;
        Renderer rend = child.GetComponent<Renderer>();
        rend.material.mainTexture = image.texture;
    }
    
    void Update()
    {
        this.transform.position += new Vector3(0,0, speed * Time.deltaTime);
        timeLeft -= Time.deltaTime;
        if(timeLeft < - 0.2f)
        {
            // removes current combo
            KeyPressEvent = GameObject.FindGameObjectWithTag("KPE");
            KeyPressEvent.currentCombo = 0;
            Destroy(this.gameObject);
        }
    }

    public void destroy(int acc)
    {

    }
}
