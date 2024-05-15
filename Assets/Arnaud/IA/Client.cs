using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Client : MonoBehaviour
{
    private NavMeshAgent client;

    bool bClientArrive = false;

    public int iNombreArmoireMax = 1;
    public int iNombreItemMax = 1;


    public Transform ArmoirePosition1;
    public Transform ArmoirePosition2;
    public Transform ArmoirePosition3;
    public Transform ArmoirePosition4;

    Transform aArmoireChoose;
    

    bool ClientFini = false;

    void Start()
    {
        client = GetComponent<NavMeshAgent>();
    }

   
    void Update()
    {
        int iNombreArmoireChoisie = Random.Range(0,2);

        for(int i = 0; i < iNombreArmoireChoisie; i++)
        {
            
            int iArmoireChoose = Random.Range(1,iNombreArmoireMax);

            switch(iArmoireChoose)
            {
                case 1:
                aArmoireChoose = ArmoirePosition1;
                break;

                case 2:
                aArmoireChoose = ArmoirePosition2;
                break;

                case 3:
                aArmoireChoose = ArmoirePosition3;
                break;

                case 4:
                aArmoireChoose = ArmoirePosition4;
                break;

            }

            client.SetDestination(aArmoireChoose.position);
    }
        


    /*void ClientArrive()
    {
        bClientArrive = true;
        
    }

    void ClientSpawn()
    {
        int iNombreArmoireChoisie = Random.Range(0,2);

        for(int i = 0; i < iNombreArmoireChoisie; i++)
        {


            
            int iArmoireChoose = Random.Range(1,iNombreArmoireMax);

            switch(iArmoireChoose)
            {
                case 1:
                aArmoireChoose = ArmoirePosition1;
                break;

                case 2:
                aArmoireChoose = ArmoirePosition2;
                break;

                case 3:
                aArmoireChoose = ArmoirePosition3;
                break;

                case 4:
                aArmoireChoose = ArmoirePosition4;
                break;

            }

            client.SetDestination(aArmoireChoose.position);
            
            while(ClientFini == false)
            {
                
                
                
                ClientFini = true;
            }
            
        }
        */
    }
    
}
    
    
    



    






