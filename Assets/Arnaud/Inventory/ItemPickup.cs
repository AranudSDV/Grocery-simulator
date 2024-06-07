using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{

    public bool Itempickup = false;
    public GameObject GOItem;
    public float Force_Max = 2f;
    float force;


    public void PickUp()
    {
        Itempickup = true;

        GOItem.transform.SetParent(Camera.main.transform);

        Rigidbody myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.useGravity = false;
    }

   
    public void Drop()
    {
        
        Debug.Log(force);
        Itempickup = false;

        Rigidbody myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.useGravity = true;

        GOItem.transform.SetParent(null);
        myRigidbody.AddForce(0, 0, Force_Max, ForceMode.Impulse);
    }

    public void ItemInArmoire()
    {
        Itempickup = false;
    }

    public void ItemPlaceCaisse()
    {
        Rigidbody myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.useGravity = true;
        myRigidbody.isKinematic = false;
        myRigidbody.detectCollisions = true;
    }

    void Update()
    {
        if(Itempickup == true)
        {   
            transform.localPosition = new Vector3(0f, 0f, 1f);
        }
    }

}
