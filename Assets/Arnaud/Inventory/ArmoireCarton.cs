using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmoireCarton : MonoBehaviour
{

  public List<GameObject> Slots = new List<GameObject>();
  public List<bool> SlotsOccupied = new List<bool>();
  public List<GameObject> ItemSlots = new List<GameObject>();

  public GameObject Player;
  public GameObject ObjetInHand;
  public GameObject ObjectTake;
  public ItemPickup ItemPickup;

  public List<GameObject> ItemInArmoire = new List<GameObject>();




  void Start()
  {

    for (int i = 0; i < 9; i++)
    {
      SlotsOccupied.Add(false);
      ItemSlots.Add(null);
      ItemInArmoire.Add(null);
    }

  }

    
  void Update()
  {
    ObjetInHand = Player.GetComponent<PlayerMovement>().ObjetInHand;

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
    ObjetInHand.transform.rotation = Quaternion.Euler(-90, 0, 0);

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
    
}


