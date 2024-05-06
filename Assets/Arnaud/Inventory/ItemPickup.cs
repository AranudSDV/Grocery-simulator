using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{

    public bool Itempickup = false;
    public GameObject GOItem;
    //public Transform ItemPos;

    

    
    


    public void PickUp()
    {
        Itempickup = true;

        GOItem.transform.SetParent(Camera.main.transform);

        Rigidbody myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.useGravity = false;
    }

   
    public void Drop()
    {

        Itempickup = false;

        Rigidbody myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.useGravity = true;

        GOItem.transform.SetParent(null);
    }

    void Update()
    {
        if(Itempickup == true)
        {   
            transform.localPosition = new Vector3(0f, 0f, 1f);
        }
    }

}
