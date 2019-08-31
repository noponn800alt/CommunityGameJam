using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    Player player;
    public ExitCounter exitCounter;

    private void OnCollisionEnter(Collision collision)
    {
        player = collision.gameObject.GetComponent<Player>();

        if(player != null)
        {
            SceneManager.LoadScene(0);
            print("Loading starting room");
            //loads starting room
        }
    }
}
