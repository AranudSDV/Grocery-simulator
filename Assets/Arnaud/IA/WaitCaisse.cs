using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitCaisse : MonoBehaviour
{
    
    public Collider Scanner;
    public Caisse Caisse;


    private void OnTriggerEnter (Collider Scanner)
    {
        if(Scanner.gameObject.tag == "Client")
        {
            Caisse.GetComponent<Caisse>().BFile2 = true;
            Scanner.GetComponent<Client>().CLientAttente1 = true;
            
        }
    }

    private void OnTriggerExit (Collider Scanner)
    {
        if(Scanner.gameObject.tag == "Client")
        {
            Caisse.GetComponent<Caisse>().BFile2 = false;
            Scanner.GetComponent<Client>().CLientAttente1 = false;

        }
        
    }
    
    
}
