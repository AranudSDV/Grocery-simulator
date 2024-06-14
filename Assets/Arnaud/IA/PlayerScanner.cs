using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScanner : MonoBehaviour
{
    public Collider PlayerScanne;
    public GameObject Caisse;
    public GameObject Player;
    public Client Client;
    public bool Encaisse = false;


    private void OnTriggerStay (Collider PlayerScanne)
    {
        if(PlayerScanne.gameObject.tag == "Client")
        {
            Caisse.GetComponent<Caisse>().BFile1 = true;
            PlayerScanne.GetComponent<Client>().CLientALaCaisse = true;

            Player = PlayerScanne.gameObject;
            Client client = Player.GetComponent<Client>();

            if(Encaisse == true)
            {
                client.CLientCaisse = true;
            }
        }
        
        
    }

    private void OnTriggerExit (Collider PlayerScanne)
    {
        if(PlayerScanne.gameObject.tag == "Client")
        {
            Caisse.GetComponent<Caisse>().BFile1 = false;
            PlayerScanne.GetComponent<Client>().CLientALaCaisse = false;

            Player = PlayerScanne.gameObject;
            Client client = Player.GetComponent<Client>();

            client.CLientCaisse = false;
        }
        

    }
    
}
