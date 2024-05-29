using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmoireTest : MonoBehaviour
{
    
    public GameObject[] Slots;
    public bool[] SlotsOccupied;
    public GameObject[] ItemSlots;

    public GameObject Player;
    public GameObject ObjetInHand;
    
    public bool EstVide = true;

    void Start()
    {
        InitializeSlots();
        UpdateEstVide();
    }

    void Update()
    {
        ObjetInHand = Player.GetComponent<PlayerMovement>().ObjetInHand;
        UpdateEstVide();
    }

    void InitializeSlots()
    {
        int numberOfSlots = Slots.Length;
        SlotsOccupied = new bool[numberOfSlots];
        ItemSlots = new GameObject[numberOfSlots];

        for (int i = 0; i < numberOfSlots; i++)
        {
            SlotsOccupied[i] = false;
            ItemSlots[i] = null;
        }
    }

    void UpdateEstVide()
    {
        EstVide = true;
        foreach (bool occupied in SlotsOccupied)
        {
            if (occupied)
            {
                EstVide = false;
                break;
            }
        }
    }

    public void AddItemToSlot(GameObject item)
    {
        for (int i = 0; i < Slots.Length; i++)
        {
            if (!SlotsOccupied[i])
            {
                PlaceItemInSlot(item, i);
                SlotsOccupied[i] = true;
                ItemSlots[i] = item;
                break;
            }
        }
        UpdateEstVide();
    }

    public void RemoveItemFromSlot(GameObject item)
    {
        for (int i = 0; i < ItemSlots.Length; i++)
        {
            if (ItemSlots[i] == item)
            {
                ClearSlot(i);
                SlotsOccupied[i] = false;
                ItemSlots[i] = null;
                break;
            }
        }
        UpdateEstVide();
    }

    void PlaceItemInSlot(GameObject item, int slotIndex)
    {
        item.transform.SetParent(Slots[slotIndex].transform);
        item.transform.localPosition = Vector3.zero;
        item.transform.localRotation = Quaternion.identity;
        Rigidbody rb = item.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = true;
            rb.detectCollisions = false;
        }
    }

    void ClearSlot(int slotIndex)
    {
        Transform slotTransform = Slots[slotIndex].transform;
        if (slotTransform.childCount > 0)
        {
            GameObject item = slotTransform.GetChild(0).gameObject;
            item.transform.SetParent(null);
            Rigidbody rb = item.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = false;
                rb.detectCollisions = true;
            }
        }
    }
}
