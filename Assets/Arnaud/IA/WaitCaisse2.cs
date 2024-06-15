using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitCaisse2 : MonoBehaviour
{
    
    public Collider Scanner;
    public ManagerFilleDattente ManagerFilleDattente;
    public GameObject Client;


    private void OnTriggerEnter (Collider Scanner)
    {
        if(Scanner.gameObject.tag == "Client")
        {
            Client = Scanner.gameObject;
            ManagerFilleDattente.point2Occuped = true;
        }
    }

    private void OnTriggerExit (Collider Scanner)
    {
        if(Scanner.gameObject.tag == "Client")
        {
            Client = null;
            ManagerFilleDattente.point2Occuped = false;
        }
        
    }
    
}
