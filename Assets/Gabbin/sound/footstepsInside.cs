using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footstepsInside : MonoBehaviour
{
    Collider soundTrigger;
    public footsteps Player;

    void Awake()
    {
        soundTrigger = GetComponent<Collider>();
    }

    void OnTriggerEnter(Collider collider)
    {
        if ( collider.gameObject.tag == "Player")
        {
            Player.Inside = true;
        }
        
    }

    void OnTriggerExit(Collider collider)
    {
        Player.Inside = false;
    }
}
