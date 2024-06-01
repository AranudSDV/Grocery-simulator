using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Client : MonoBehaviour
{
    private NavMeshAgent client;
    public GameObject GOclient;

    public bool bClientArrive = false;

    public int iNombreArmoireMax = 1;
    public int iNombreItemMax = 1;

    public GameObject[] armoires;

    public List<GameObject> IAInventaire;

    public ArmoireManager ArmoireManager;
    public Armoire Armoire;

    bool ClientFini = false;

    public bool clientspawn = false;

    public Armoire targetArmoire;
    public GameObject ItemSelected;
    public int ItemSelectedIndex;

    public int IANombreMaxItem = 10;


    void Start()
    {
        List<GameObject> IAInventaire = new List<GameObject>();
        client = GetComponent<NavMeshAgent>();
        clientspawn = true;
        
        
    }

   
    void Update()
    {

        if(bClientArrive == true)
        {
            client.ResetPath();
            int NombreItemCHoisi = Random.Range(1, IANombreMaxItem);

            Debug.Log("Nombre item choisi" + NombreItemCHoisi);

            for(int i = 0; i < NombreItemCHoisi; i++)
            {
                var itemWithIndex = targetArmoire.GetRandomOccupiedObject();
                if (itemWithIndex != null)
                {
                    ItemSelected = itemWithIndex.GameObject;
                    ItemSelectedIndex = itemWithIndex.Index; 
                    IAInventaire.Add(ItemSelected);

                    targetArmoire.IATake();

                    ItemSelected.transform.SetParent(GOclient.transform);
                    ItemSelected.transform.localPosition = new Vector3(0f, 0f, 0f);
                }
                
                
            }
            
            Debug.Log("Client Sortie boucle for");
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
        yield return new WaitForSeconds(20);
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
    
