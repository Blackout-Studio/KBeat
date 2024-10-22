﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//Autor - Milan Savickij
public class KeyTyping : MonoBehaviour
{

    private readonly Array keyCodes = Enum.GetValues(typeof(KeyCode));
    public KeyPressEvent kpEvent;

    void Start() 
    {
        kpEvent = this.gameObject.GetComponent<KeyPressEvent>();
    }

    void Update()
    {
        if (Input.anyKeyDown) {

            foreach (KeyCode keyCode in keyCodes)
            {
                if (Input.GetKey(keyCode))
                {
                    //Debug.Log("KeyCode down: " + keyCode + " current time: " + Time.time * 1000);
                    kpEvent.keyPressed(keyCode);
                    break;
                }
            }
        }
    }
}
