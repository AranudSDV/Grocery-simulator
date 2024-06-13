using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbianceSound : MonoBehaviour
{
    AudioSource source;

    Collider soundTrigger;


    void Awake()
    {
        source = GetComponent<AudioSource>();
        soundTrigger = GetComponent<Collider>();
    }

    void OnTriggerEnter(Collider collider)
    {
        if ( collider.gameObject.tag == "Player")
        {
            source.Play();
        }
        
    }

    void OnTriggerExit(Collider collider)
    {
        source.Stop();
    }
}
