using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footstepsOutside : MonoBehaviour

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
            Player.Outside = true;
        }
        
    }

    void OnTriggerExit(Collider collider)
    {
        Player.Outside = false;
    }
}
