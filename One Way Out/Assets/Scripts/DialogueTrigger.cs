using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class DialogueTrigger : MonoBehaviour
{
    public UIManager uiManager;

    public string message;

    bool triggered = false;

    private void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Player>() != null && !triggered)
        {
            print("Dialogue set");

            uiManager.ShowDialogue(message);

            triggered = true;
        }
    }
}
