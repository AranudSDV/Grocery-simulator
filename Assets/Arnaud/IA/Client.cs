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

    public ArmoireManager ArmoireManager;

    bool ClientFini = false;

    public LayerMask ArmoireMask;

    public bool clientspawn = false;

    void Start()
    {
        client = GetComponent<NavMeshAgent>();
        clientspawn = true;
        
        
    }

   
    void Update()
    {

        if(bClientArrive == true)
        {
            Debug.Log("client arrive = true");
            client.ResetPath();
            bClientArrive = false;
        }

        if(clientspawn == true)
        {
            StartCoroutine(FinGame());
            clientspawn = false;
            
        }
        

        

        //Debug.DrawRay(transform.position, client.transform.TransformDirection(Vector3.forward), Color.green);

        //NavMeshHit hit;
        
        //bClientArrive = NavMesh.Raycast(transform.position, client.transform.TransformDirection(Vector3.forward), out hit,  NavMesh.AllAreas);
    }

    IEnumerator FinGame()
    {
        yield return new WaitForSeconds(10);
        ClientSpawn();
    }
        
    

    public void ClientSpawn()
    {
        
        Armoire targetArmoire = ArmoireManager.GetRandomNonEmptyShelf();

        if (targetArmoire != null)
        {
            
            client.SetDestination(targetArmoire.transform.position);
            
        }
        else
        {
            Debug.Log("Toutes les armoires sont vides.");
        }
    
    }
    

    public void ClientArrive()
    {
        bClientArrive = true;
    }

    

}
    
    
    



    






