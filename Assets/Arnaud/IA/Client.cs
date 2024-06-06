using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Client : MonoBehaviour
{
    private NavMeshAgent client;
    public GameObject GOclient;

    public bool bClientArriveArmoire = false;
    public bool bClientRecupereItem = false;

    public bool bClientArriveCaisse = false;

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
    public int IANombreMinItem = 3;

    public GameObject TargetCaisse;
    public GameObject ItemCaissePos;

    private bool itemsPlaced = false;
    private float DistanceCaisse = 0.5f;

    public ItemPickup ItemPickup;

    public Caisse Caisse;
    public bool encaisse;
    public bool CLientCaisse = false;

    public GameObject SortieClient;


    void Start()
    {
        List<GameObject> IAInventaire = new List<GameObject>();
        client = GetComponent<NavMeshAgent>();
        clientspawn = true;
        
        
    }

   
    void Update()
    {

        if(bClientArriveArmoire == true)
        {
            client.ResetPath();
            int NombreItemCHoisi = Random.Range(IANombreMinItem, IANombreMaxItem);

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
            

            bClientRecupereItem = true;
            bClientArriveArmoire = false;
        
        }

        if(bClientRecupereItem == true && bClientArriveCaisse == false)
        {
            client.SetDestination(TargetCaisse.transform.position);
        }

        if(clientspawn == true)
        {
            StartCoroutine(Debut());
            clientspawn = false;
            
        }
        
        if (bClientRecupereItem && !bClientArriveCaisse && HasReachedDestination(TargetCaisse.transform.position))
        {

            PlaceItemsAtCaisse();
            bClientArriveCaisse = true;
        }

        if(CLientCaisse == true)
        {
            client.SetDestination(SortieClient.transform.position);
        }
        
    }

    IEnumerator Debut()
    {
        yield return new WaitForSeconds(20);
        ClientSpawn();
    }

    IEnumerator Fin()
    {
        yield return new WaitForSeconds(60);
        Destroy(this);
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
    
    }
    

    public void ClientArrive()
    {
        bClientArriveArmoire = true;
    }

    private void PlaceItemsAtCaisse()
    {

        foreach (GameObject item in IAInventaire)
        {
            var itemPickup = item.GetComponent<ItemPickup>();
            itemPickup.ItemPlaceCaisse();
            item.transform.SetParent(ItemCaissePos.transform);
            item.transform.localPosition = new Vector3(0f, 0f, 0f);
        }
        itemsPlaced = true;
    }

    private bool HasReachedDestination(Vector3 destination)
    {
        float distance = Vector3.Distance(client.transform.position, destination);
        return distance < DistanceCaisse;
    }

    public void encaissement()
    {
        CLientCaisse = true;
    }

    

}
    
