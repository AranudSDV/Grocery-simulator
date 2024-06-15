using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderArmoire : MonoBehaviour
{

    public bool IAWait = false;
    public Collider ClientArrive;
    public GameObject client;



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
    


    if( IAWait == true && ClientArrive.gameObject.tag == "Client")
    {

      client = ClientArrive.gameObject;

      client.GetComponent<Client>().ClientArrive();
    }
   }
    
}
