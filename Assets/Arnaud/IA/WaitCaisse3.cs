using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitCaisse3 : MonoBehaviour
{
    public Collider Scanner;
    public Caisse Caisse;


    private void OnTriggerEnter (Collider Scanner)
    {
        if(Scanner.gameObject.tag == "Client")
        {
            Caisse.GetComponent<Caisse>().BFile4 = true;
            Scanner.GetComponent<Client>().CLientAttente3 = true;
        }
    }

    private void OnTriggerExit (Collider Scanner)
    {
        if(Scanner.gameObject.tag == "Client")
        {
            Caisse.GetComponent<Caisse>().BFile4 = false;
            Scanner.GetComponent<Client>().CLientAttente3 = false;
        }
        
    }
    
}
