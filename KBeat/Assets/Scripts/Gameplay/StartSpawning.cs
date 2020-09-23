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

    [SerializeField]
    private Sprite[] letters;
    //private char[] c = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
    [SerializeField]
    private KeyCode[] chars;
    public void spawnOnBeat(int reactionTime)
    {
        int key = Random.Range(0, chars.Length);
        //KeyCode kc = (KeyCode)System.Enum.Parse(typeof(KeyCode), c[key].ToString());
        Note n = Instantiate(note,new Vector3(4,-1,-16), Quaternion.EulerAngles(90,0,0)).GetComponent<Note>();
        n.Initialize(cooldown, chars[key], reactionTime, letters[key]);
        kpe.addNote(n);
    }

   
}
