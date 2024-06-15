using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerFilleDattente : MonoBehaviour
{
    public bool point1Occuped;
    public bool point2Occuped;
    public bool point3Occuped;
    public bool point4Occuped;

    public GameObject Client1;
    public GameObject Client2;
    public GameObject Client3;
    public GameObject Client4;

    public WaitCaisse WaitCaisse;
    public WaitCaisse2 WaitCaisse2;
    public WaitCaisse3 WaitCaisse3;
    public WaitCaisse4 WaitCaisse4;

    public bool EncaissementClient;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Client1 = WaitCaisse.Client;
        Client2 = WaitCaisse2.Client;
        Client3 = WaitCaisse3.Client;
        Client4 = WaitCaisse4.Client;

        if(point1Occuped == false && point2Occuped == true && EncaissementClient == true)
        {
            
            Client2.GetComponent<Client>().Avance();
            Client3.GetComponent<Client>().Avance();
            Client4.GetComponent<Client>().Avance();
            EncaissementClient = false;
        }
    }
}
