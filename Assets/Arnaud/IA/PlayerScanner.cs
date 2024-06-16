using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScanner : MonoBehaviour
{
    public Collider PlayerScanne;
    public GameObject Caisse;
    public GameObject Player;
    public bool Encaisse = false;
    Client client;

    public void Update()
    {
        
    }

    private void OnTriggerStay (Collider PlayerScanne)
    {
        if(PlayerScanne.gameObject.tag == "Client")
        {
            Player = PlayerScanne.gameObject;
            client = Player.GetComponent<Client>(); 

            if(Encaisse == true)
            {
            client.CLientCaisse = true;
            Encaisse = false;
            } 
        }
        
        
    }

    private void OnTriggerExit (Collider PlayerScanne)
    {
        if(PlayerScanne.gameObject.tag == "Client")
        {

            Player = PlayerScanne.gameObject;
            Client client = Player.GetComponent<Client>();

            client.CLientCaisse = false;
            Encaisse = false;
            
        }
        

    }
    
}
