using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Autor - Milan Savickij
public class Note : MonoBehaviour
{

    private double time;
    private double cooldown;
    public KeyCode key;
    private float speed;

    //public int order;

    /*public Note(double time, double timeToHit, KeyCode kcode) 
    {
        this.time = time;
        this.cooldown = timeToHit;
        this.key = kcode;
        speed = Mathf.Abs(this.gameObject.transform.position.z - 4)/(float)this.cooldown;
    }
*/
    public void Initialize(double time, double timeToHit, KeyCode kcode)
    {
        this.time = time;
        this.cooldown = timeToHit;
        this.key = kcode;
        speed = (float)Mathf.Abs(this.gameObject.transform.position.z - 4)/(float)this.cooldown;
    }
    
    void Update()
    {
        this.transform.position += new Vector3(0,0, speed * Time.deltaTime);
    }

    /*public void isPressed(KeyCode kcode, double millis) 
    {
        /*Debug.Log("isPressed");
        if (millis-time < cooldown && key == kcode && millis-time > 0) 
        {
            Debug.Log("Note was sucessfully hit");
        } else if (millis-time < 0)
        {
            destroy(0);
        }

        if(kcode == key)
        {
            Destroy(this.gameObject);
        }
    }*/

    public void destroy(int acc)
    {

    }
}
