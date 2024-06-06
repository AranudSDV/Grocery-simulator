using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScanner : MonoBehaviour
{
    public Collider PlayerScanne;
    public GameObject Player;
    public Client Client;
    public bool Encaisse = false;


    private void OnTriggerStay (Collider PlayerScanne)
    {
        Player = PlayerScanne.gameObject;
        var client = Player.GetComponent<Client>();

        if(Encaisse == true)
        {
            client.CLientCaisse = true;
        }
        
    }

    private void OnTriggerExit (Collider PlayerScanne)
    {
        Player = PlayerScanne.gameObject;
        var client = Player.GetComponent<Client>();

        client.CLientCaisse = false;
    }
    
}
