using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text dialogueBox;
    public Text exitCounterBox;
    public ExitCounter exitCounter;

    public string[] exitLines;
    // Start is called before the first frame update
    void Start()
    {
<<<<<<< Updated upstream
        dialogueBox.text = "Welcome to the game!";
=======
        dialogueBox.text = "This is the dialogue box";
        exitLines = new string[] {"Hey, you got to the end! Now stop playing and enjoy finishing the game!", "Wait, what are you doing? The game is over already.",
        "Stop. Now. This is not a game anymore.", "I've had enough."};
    }

    private void Update()
    {
        exitCounterBox.text = "Exits found: " + exitCounter.exitsFound;
>>>>>>> Stashed changes
    }

    public void ShowDialogue(string message)
    {
        dialogueBox.text = message;
    }
}
