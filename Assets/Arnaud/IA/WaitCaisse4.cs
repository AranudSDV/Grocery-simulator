using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitCaisse4 : MonoBehaviour
{
    public Collider Scanner;
    public ManagerFilleDattente ManagerFilleDattente;
    public GameObject Client;


    private void OnTriggerEnter (Collider Scanner)
    {
        if(Scanner.gameObject.tag == "Client")
        {
            Client = Scanner.gameObject;
            ManagerFilleDattente.point4Occuped = true;
        }
    }

    private void OnTriggerExit (Collider Scanner)
    {
        if(Scanner.gameObject.tag == "Client")
        {
            Client = null;
            ManagerFilleDattente.point4Occuped = false;
        }
        
    }
}
