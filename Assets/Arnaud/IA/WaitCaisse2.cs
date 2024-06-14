using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitCaisse2 : MonoBehaviour
{
    
    public Collider Scanner;
    public Caisse Caisse;


    private void OnTriggerEnter (Collider Scanner)
    {
        if(Scanner.gameObject.tag == "Client")
        {
            Caisse.GetComponent<Caisse>().BFile3 = true;
            Scanner.GetComponent<Client>().CLientAttente2 = true;
        }
    }

    private void OnTriggerExit (Collider Scanner)
    {
        if(Scanner.gameObject.tag == "Client")
        {
            Caisse.GetComponent<Caisse>().BFile3 = false;
            Scanner.GetComponent<Client>().CLientAttente2 = false;
        }
        
    }
    
}
