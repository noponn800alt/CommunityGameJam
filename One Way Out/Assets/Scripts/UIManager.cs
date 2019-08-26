﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text dialogueBox;
    // Start is called before the first frame update
    void Start()
    {
        dialogueBox.text = "This is the dialogue box";
    }

    public void ShowDialogue(string message)
    {
        dialogueBox.text = message;
    }
}
