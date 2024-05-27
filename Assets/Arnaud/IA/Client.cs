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
    public  GameObject goArmoire1;

    public Transform ArmoirePosition2;
    public  GameObject goArmoire2;

    public Transform ArmoirePosition3;
    public  GameObject goArmoire3;

    public Transform ArmoirePosition4;
    public  GameObject goArmoire4;

    public GameObject[] armoires;


    Transform aArmoireChoose;

    public  GameObject goArmoireChoose;
    
    
    public Transform Player;


    

    bool ClientFini = false;

    public LayerMask ArmoireMask;

    void Start()
    {
        client = GetComponent<NavMeshAgent>();
        //ClientSpawn();

    }

   
    void Update()
    {

        if(bClientArrive == true)
        {
            Debug.Log("client arrive = true");
            client.ResetPath();
            bClientArrive = false;
        }

        //Debug.DrawRay(transform.position, client.transform.TransformDirection(Vector3.forward), Color.green);

        //NavMeshHit hit;
        
        //bClientArrive = NavMesh.Raycast(transform.position, client.transform.TransformDirection(Vector3.forward), out hit,  NavMesh.AllAreas);
    }

    
        

    /*void ClientSpawn()
    {
        
        int iNombreArmoireChoisie = Random.Range(0,1);

        for(int i = 0; i < 2; i++)
        {
            
            int indexAleatoire = Random.Range(0, armoiresAvecObjets.Count);

            

            if(bClientArrive == false)
            {
                client.SetDestination(armoire.transform.position);
            }

            
        }
    
    }
    */

    public void ClientArrive()
    {
        bClientArrive = true;
    }

    

}
    
    
    



    






