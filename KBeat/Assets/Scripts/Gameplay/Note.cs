using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Autor - Milan Savickij
public class Note : MonoBehaviour
{
    public double timeLeft;
    public KeyCode key;
    private float speed;

    public void Initialize(double timeToHit, KeyCode kcode, int reactionTime)
    {
        this.timeLeft = timeToHit*reactionTime;
        this.key = kcode;
        speed = (float)Mathf.Abs(this.gameObject.transform.position.z - 4)/(float)this.timeLeft;
    }
    
    void Update()
    {
        this.transform.position += new Vector3(0,0, speed * Time.deltaTime);
        timeLeft -= Time.deltaTime;
        if(timeLeft < - 0.2f)
        {
            Destroy(this.gameObject);
        }
    }

    public void destroy(int acc)
    {

    }
}
