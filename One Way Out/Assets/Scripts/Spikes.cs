using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    public bool fake;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<Player>() != null || !fake)
        {
            other.gameObject.GetComponent<Player>().Respawn(0);
        }
    }
}
