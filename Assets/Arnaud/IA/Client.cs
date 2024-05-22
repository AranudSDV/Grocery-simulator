using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Client : MonoBehaviour
{
    private NavMeshAgent client;

    public bool bClientArrive = false;

    public int iNombreArmoireMax = 1;
    public int iNombreItemMax = 1;


    public Transform ArmoirePosition1;
    public Transform ArmoirePosition2;
    public Transform ArmoirePosition3;
    public Transform ArmoirePosition4;

    Transform aArmoireChoose;
    

    bool ClientFini = false;

    public LayerMask ArmoireMask;

    void Start()
    {
        client = GetComponent<NavMeshAgent>();
        ClientSpawn();
    }

   
    void Update()
    {

        if(bClientArrive == true)
        {
            Debug.Log("client arrive = true");
            client.isStopped = true;
            client.ResetPath();
        }

        //Debug.DrawRay(transform.position, client.transform.TransformDirection(Vector3.forward), Color.green);

        //NavMeshHit hit;
        
        //bClientArrive = NavMesh.Raycast(transform.position, client.transform.TransformDirection(Vector3.forward), out hit,  NavMesh.AllAreas);
    }
        

    void ClientSpawn()
    {
        
        int iNombreArmoireChoisie = Random.Range(0,1);

        for(int i = 0; i < 2; i++)
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

                case 5:
                aArmoireChoose = ArmoirePosition4;
                break;

            }

            
            
            

            
            if(bClientArrive == false)
            {
                client.SetDestination(aArmoireChoose.position);


                Debug.Log(" client arrive == false");

            }

            
        }
    
    }

    public void ClientArrive()
    {
        bClientArrive = true;
    
    }
}
    
    
    



    






