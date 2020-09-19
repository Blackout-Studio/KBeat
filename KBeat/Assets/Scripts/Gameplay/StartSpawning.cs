using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Autor - Matyáš Himmer & Milan Savickij
public class StartSpawning : MonoBehaviour
{
    [SerializeField]
    private GameObject note;

    public KeyPressEvent kpe;
    public double cooldown;
    private char[] c = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
    public void spawnOnBeat()
    {
        int key = Random.Range(0, c.Length);
        //KeyCode kc = (KeyCode)System.Enum.Parse(typeof(KeyCode), c[key].ToString());
        Note n = Instantiate(note,new Vector3(4,-1,-16), Quaternion.EulerAngles(90,0,0)).GetComponent<Note>();
        
        n.Initialize(Time.time * 1000, cooldown, KeyCode.A);
        kpe.addNote(n);
    }

   
}
