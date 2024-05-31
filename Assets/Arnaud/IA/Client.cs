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

    public GameObject[] Inventaire;
    public GameObject ItemPick;


    Transform aArmoireChoose;

    public  GameObject goArmoireChoose;
    
    
    public Transform Player;

    public ArmoireManager ArmoireManager;
    public Armoire Armoire;

    bool ClientFini = false;

    public LayerMask ArmoireMask;

    public bool clientspawn = false;

    public int IndexRandomArmoire;

    public Armoire targetArmoire;

    void Start()
    {
        client = GetComponent<NavMeshAgent>();
        clientspawn = true;
        
        
    }

   
    void Update()
    {

        if(bClientArrive == true)
        {
        
            IndexRandomArmoire = targetArmoire.GetRandomOccupiedIndex();
            Debug.Log(IndexRandomArmoire);
            client.ResetPath();
            bClientArrive = false;
            
            
        }

        if(clientspawn == true)
        {
            StartCoroutine(Debut());
            clientspawn = false;
            
        }
        

        

        //Debug.DrawRay(transform.position, client.transform.TransformDirection(Vector3.forward), Color.green);

        //NavMeshHit hit;
        
        //bClientArrive = NavMesh.Raycast(transform.position, client.transform.TransformDirection(Vector3.forward), out hit,  NavMesh.AllAreas);
    }

    IEnumerator Debut()
    {
        yield return new WaitForSeconds(10);
        ClientSpawn();
    }
        
    

    public void ClientSpawn()
    {
        
        targetArmoire = ArmoireManager.GetRandomNonEmptyShelf();

        if (targetArmoire != null)
        {
            
            client.SetDestination(targetArmoire.RecupPoint.transform.position);
            
        }
        else
        {
            Debug.Log("Toutes les armoires sont vides.");
        }

        if(bClientArrive == true)
        {
            
        }
    
    }
    

    public void ClientArrive()
    {
        bClientArrive = true;
        
        
        
    }

    

}
    
    
    



    






