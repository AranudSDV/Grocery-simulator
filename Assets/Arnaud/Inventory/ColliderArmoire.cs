using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderArmoire : MonoBehaviour
{

    public bool IAWait = false;
    public Collider ClientArrive;
    GameObject client;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter (Collider ClientArrive)
   {
    IAWait = true;

    if( IAWait == true)
    {
      Debug.Log("Collider armoire ia wait");

      client = ClientArrive.gameObject;

      client.GetComponent<Client>().ClientArrive();
    }
   }
    
}