using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbianceSound : MonoBehaviour
{
    AudioSource source;

    Collider soundTrigger;
    

    void Start()
    {
        source = GetComponent<AudioSource>();
        soundTrigger = GetComponent<Collider>();
    }
    void Update()
    {
        
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
        if ( collider.gameObject.tag == "Player")
        {
            Debug.Log("Son Trigger exit");
            source.Stop();
        }
        
    }
}
