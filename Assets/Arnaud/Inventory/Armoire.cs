using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armoire : MonoBehaviour
{
  public List<GameObject> Slots = new List<GameObject>();
  public List<bool> SlotsOccupied = new List<bool>();
  public List<GameObject> ItemSlots = new List<GameObject>();

  public GameObject Player;
  public GameObject ObjetInHand;
  public GameObject ObjectTake;
  public ItemPickup ItemPickup;

    
  GameObject client;

  public bool EstVide = false;

  public List<GameObject> ItemInArmoire = new List<GameObject>();

  public GameObject RecupPoint;

  public bool IsTargeted = false;


  void Start()
  {
    StartCoroutine(TargetArmoire());

    for (int i = 0; i < 48; i++)
    {
      SlotsOccupied.Add(false);
      ItemSlots.Add(null);
      ItemInArmoire.Add(null);
    }

    GameObjectWithIndex selectedObject = GetRandomOccupiedObject();
  }

    
  void Update()
  {
    ObjetInHand = Player.GetComponent<PlayerMovement>().ObjetInHand;

    EstVide = !SlotsOccupied.Contains(true);
    
  }

  IEnumerator TargetArmoire()
  {
    yield return new WaitForSeconds(2);
    IsTargeted = false;
  }



  public void Place()
  {
    if (ObjetInHand == null) return;

    for (int i = 0; i < Slots.Count; i++)
    {
      if (!SlotsOccupied[i])
      {
        PlaceItemInSlot(i);
        return;
      }
    }
  }

  private void PlaceItemInSlot(int index)
  {
    var itemPickup = ObjetInHand.GetComponent<ItemPickup>();
    itemPickup.ItemInArmoire();
    ObjetInHand.transform.SetParent(Slots[index].transform);
    ObjetInHand.transform.localPosition = Vector3.zero;
    ObjetInHand.transform.rotation = Quaternion.identity;

    SlotsOccupied[index] = true;
    Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
    myRigidbody.isKinematic = true;
    myRigidbody.detectCollisions = false;
    ItemSlots[index] = ObjetInHand;
    ItemInArmoire[index] = ObjetInHand;
  }

  public void Take()
  {
    for (int i = 0; i < Slots.Count; i++)
    {
      if (SlotsOccupied[i])
      {
        TakeItemFromSlot(i);
        return;
      }
    }
  }

  private void TakeItemFromSlot(int index)
  {
    if (ItemSlots[index] == null) return;

    ItemSlots[index].transform.SetParent(Camera.main.transform);
    ItemSlots[index].transform.localPosition = new Vector3(0f, 0f, 1f);

    SlotsOccupied[index] = false;
    ObjectTake = ItemSlots[index];

    ItemPickup.Itempickup = true;
    Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
    myRigidbody.isKinematic = false;
    myRigidbody.detectCollisions = true;
    ItemInArmoire[index] = null;
  }



  public class GameObjectWithIndex
    {
      public GameObject GameObject { get; set; }
      public int Index { get; set; }
    }

    public GameObjectWithIndex GetRandomOccupiedObject()
    {
      List<GameObjectWithIndex> occupiedObjects = new List<GameObjectWithIndex>();

      for (int i = 0; i < ItemInArmoire.Count; i++)
      {
        if (ItemInArmoire[i] != null)
        {
          occupiedObjects.Add(new GameObjectWithIndex { GameObject = ItemInArmoire[i], Index = i });
        }
      }

      if (occupiedObjects.Count == 0)
      {
       return null;
      }

      

      int randomIndex = Random.Range(0, occupiedObjects.Count);
      return occupiedObjects[randomIndex];
    }

    public void IATake()
    {
      GameObjectWithIndex randomObject = GetRandomOccupiedObject();
      GameObject gameObject = randomObject.GameObject;
      int index = randomObject.Index;

      //SlotsOccupied[index] = false;

      //ItemInArmoire.RemoveAt(index);
      //ItemInArmoire.Insert(index, null);
      IsTargeted = false;
    }
    
}
