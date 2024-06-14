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

    public bool clientspawn = false;

    public Armoire targetArmoire;
    public GameObject ItemSelected;
    public int ItemSelectedIndex;

    public int IANombreMaxItem = 10;
    public int IANombreMinItem = 3;

    public GameObject TargetCaisse;
    public GameObject PointCaisse;
    public GameObject ItemCaissePos;

    private float DistanceCaisse = 0.5f;

    public ItemPickup ItemPickup;

    public Caisse Caisse;
    public bool encaisse;
    public bool CLientCaisse = false;

    public GameObject SortieClient;

    GameObject ItemAvecID;

    public bool CLientALaCaisse = false;
    public bool CLientAttente1 = false;
    public bool CLientAttente2 = false;
    public bool CLientAttente3 = false;


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
            
            targetArmoire.GetComponent<Armoire>().IsTargeted = false;
            bClientRecupereItem = true;
            bClientArriveArmoire = false;
        
        }
        Caisse Caisse = TargetCaisse.GetComponent<Caisse>();

        
        
        




        if(bClientRecupereItem == true && CLientALaCaisse == false)
        {
            ChoixPlace();
            client.SetDestination(PointCaisse.transform.position);
        }
        if(bClientRecupereItem == true && CLientAttente1 == true)
        {
            client.SetDestination(PointCaisse.transform.position);
        }
        if(bClientRecupereItem == true && CLientAttente2 == true)
        {
            client.SetDestination(PointCaisse.transform.position);
        }
        if(bClientRecupereItem == true && CLientAttente3 == true)
        {
            client.SetDestination(PointCaisse.transform.position);
        }
        




        if(clientspawn == true)
        {
            ClientSpawn();
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



    IEnumerator Fin()
    {
        yield return new WaitForSeconds(60);
        Destroy(this);
    }
        
    

    public void ClientSpawn()
    {
        
        targetArmoire = ArmoireManager.GetRandomNonEmptyShelf();
        targetArmoire.GetComponent<Armoire>().IsTargeted = true;

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
            ItemAvecID = item.GetComponent<ItemSansID>().IteamAvecID;
            var itemPickup = item.GetComponent<ItemPickup>();
            itemPickup.ItemPlaceCaisse();
            GameObject go = Instantiate(ItemAvecID, new Vector3(0, 0, 0), Quaternion.identity);

            go.transform.SetParent(ItemCaissePos.transform);
            go.transform.localPosition = new Vector3(0f, 0f, 0f);
            Destroy(item);
        }
        
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
    
    public void ChoixPlace()
    {
        if(Caisse.BFile1 == false)
        {
            PointCaisse = Caisse.GoBFile1;
        }
        else if (Caisse.BFile2 == false)
        {
            PointCaisse = Caisse.GoBFile2;
        }
        else if (Caisse.BFile3 == false)
        {
            PointCaisse = Caisse.GoBFile3;
        }
        else if (Caisse.BFile4 == false)
        {
            PointCaisse = Caisse.GoBFile4;
        }
        else
        {
            Caisse.CaisseFull = true;
        }
    }
    
    

}
    
