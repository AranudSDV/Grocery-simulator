using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{

    public bool Itempickup = false;
    public GameObject GOItem;
    public float ForceActuelle = 0f;
    public float ForceAugmentation = 3f;
    public float MaxForce = 15f;

    public bool MaintienForce = false;
    

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

        var direction = Camera.main.transform.forward * ForceActuelle;
        Rigidbody myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.useGravity = true;

        GOItem.transform.SetParent(null);
        myRigidbody.AddForce(direction, ForceMode.Impulse);
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
        if(MaintienForce == true)
        {
            ForceActuelle += ForceAugmentation * Time.deltaTime;
            Debug.Log("Forec" + ForceActuelle);

            if(ForceActuelle > MaxForce)
            {
            ForceActuelle = MaxForce;
            }
        }
        
        
    }


}
