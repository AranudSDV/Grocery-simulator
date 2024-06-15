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

    public GameObject Point1;
    public GameObject Point2;
    public GameObject Point3;
    public GameObject Point4;

    public int Place;
    public ManagerFilleDattente ManagerFilleDattente;
    bool BChoixCaisse;

    public GameManager GameManager;
    public bool mort;



    void Start()
    {
        List<GameObject> IAInventaire = new List<GameObject>();
        client = GetComponent<NavMeshAgent>();
        clientspawn = true;
        BChoixCaisse = false;
        
    }

   
    void Update()
    {
        

        if(bClientArriveArmoire == true)
        {
            client.ResetPath();
            int NombreItemCHoisi = Random.Range(IANombreMinItem, IANombreMaxItem);

            //Debug.Log("Nombre item choisi" + NombreItemCHoisi);

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

        
        
        



        //CHOIX CAISSE
        if(bClientRecupereItem == true && BChoixCaisse == false)
        {
            ChoixCaisse();
            BChoixCaisse = true; 
        }
       
        




        if(clientspawn == true)
        {
            ClientSpawn();
            clientspawn = false;
            
        }
        
        if (bClientRecupereItem && !bClientArriveCaisse && HasReachedDestination(Point1.transform.position))
        {

            PlaceItemsAtCaisse();
            bClientArriveCaisse = true;
        }
        
        if(HasReachedDestination(SortieClient.transform.position))
        {
            
            Destroy(this);
        }

        if(CLientCaisse == true)
        {
            Debug.Log("Client caisse == true dans sscirpt client");
            client.SetDestination(SortieClient.transform.position);
            
            
        }

        if(mort == true)
        {
            int IAWorld = GameManager.NombreDeClientInWorld;
            GameManager.NombreDeClientInWorld = IAWorld - 1;
            Debug.Log(IAWorld);
            mort = false;
        }
        
    }

        
    

    public void ClientSpawn()
    {
        
        targetArmoire = ArmoireManager.GetRandomNonEmptyShelf();
        

        if (targetArmoire != null)
        {

            client.SetDestination(targetArmoire.RecupPoint.transform.position);
            //targetArmoire.GetComponent<Armoire>().IsTargeted = true;
            
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
    
    
    public void ChoixCaisse()
    {
        if(ManagerFilleDattente.point1Occuped == true && ManagerFilleDattente.point2Occuped == true && ManagerFilleDattente.point3Occuped == true && ManagerFilleDattente.point4Occuped == true)
        {
          
        }
        
        if(ManagerFilleDattente.point1Occuped == true && ManagerFilleDattente.point2Occuped == true && ManagerFilleDattente.point3Occuped == true && ManagerFilleDattente.point4Occuped == false)
        {
            client.SetDestination(Point4.transform.position);
            Place = 4;
        }

        if(ManagerFilleDattente.point1Occuped == true && ManagerFilleDattente.point2Occuped == true && ManagerFilleDattente.point3Occuped == false && ManagerFilleDattente.point4Occuped == false)
        {
            client.SetDestination(Point3.transform.position);
            Place = 3;
        }

        if(ManagerFilleDattente.point1Occuped == true && ManagerFilleDattente.point2Occuped == false && ManagerFilleDattente.point3Occuped == false && ManagerFilleDattente.point4Occuped == false)
        {
            client.SetDestination(Point2.transform.position);
            Place = 2;
        }

        if(ManagerFilleDattente.point1Occuped == false && ManagerFilleDattente.point2Occuped == false && ManagerFilleDattente.point3Occuped == false && ManagerFilleDattente.point4Occuped == false)
        {
            client.SetDestination(Point1.transform.position);
            Place = 1;
        }
    }

    public void Avance()
    {   

        if(Place == 2)
        {
            
            client.SetDestination(Point1.transform.position);
            Place = 1;
        }

        if(Place == 3)
        {
           
            client.SetDestination(Point2.transform.position);
            Place = 2;
        }

        if(Place == 4)
        {
            client.SetDestination(Point3.transform.position);
            Place = 3;
        }
        ManagerFilleDattente.EncaissementClient = false;

    }
    

}
    
