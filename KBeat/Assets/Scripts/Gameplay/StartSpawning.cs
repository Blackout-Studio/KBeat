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
    private KeyCode[] letters = {KeyCode.A, KeyCode.B, KeyCode.C, KeyCode.D, KeyCode.E, KeyCode.F, KeyCode.G, KeyCode.H,
                                 KeyCode.I, KeyCode.J, KeyCode.K, KeyCode.L, KeyCode.M, KeyCode.N, KeyCode.O, KeyCode.P,
                                 KeyCode.Q, KeyCode.R, KeyCode.S, KeyCode.T, KeyCode.U, KeyCode.V, KeyCode.W, KeyCode.X, 
                                 KeyCode.Y, KeyCode.Z};
    [SerializeField]
    private Sprite[] sprites;
    public void spawnOnBeat(int reactionTime)
    {
        int key = Random.Range(0, letters.Length);
        //KeyCode kc = (KeyCode)System.Enum.Parse(typeof(KeyCode), c[key].ToString());
        Note n = Instantiate(note,new Vector3(4,-1,-16), Quaternion.EulerAngles(-90f,0f,0f)).GetComponent<Note>();
        n.Initialize(cooldown, letters[key], reactionTime, sprites[key]);
        kpe.addNote(n);
    }

   
}
