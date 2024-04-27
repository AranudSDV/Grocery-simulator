using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caisse : MonoBehaviour
{
    public Collider lecteur;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter (Collider lecteur)
  {
    Debug.Log("lecteur teste");
    
  }
}
