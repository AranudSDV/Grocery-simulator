using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armoire : MonoBehaviour
{
    //EMPLACEMENT 1
    public GameObject Slot1;
    public bool Solt1Occuped = false;
    public GameObject Slot2;
    public bool Solt2Occuped = false;
    public GameObject Slot3;
    public bool Solt3Occuped = false;
    public GameObject Slot4;
    public bool Solt4Occuped = false;
    public GameObject Slot5;
    public bool Solt5Occuped = false;
    public GameObject Slot6;
    public bool Solt6Occuped = false;

    public bool Emplacement1Full = false;

    //EMPLACEMENT 2
    public GameObject Slot7;
    public bool Solt7Occuped = false;
    public GameObject Slot8;
    public bool Solt8Occuped = false;
    public GameObject Slot9;
    public bool Solt9Occuped = false;
    public GameObject Slot10;
    public bool Solt10Occuped = false;
    public GameObject Slot11;
    public bool Solt11Occuped = false;
    public GameObject Slot12;
    public bool Solt12Occuped = false;

    public bool Emplacement2Full = false;


    //EMPLACEMENT 3
    public GameObject Slot13;
    public bool Solt13Occuped = false;
    public GameObject Slot14;
    public bool Solt14Occuped = false;
    public GameObject Slot15;
    public bool Solt15Occuped = false;
    public GameObject Slot16;
    public bool Solt16Occuped = false;
    public GameObject Slot17;
    public bool Solt17Occuped = false;
    public GameObject Slot18;
    public bool Solt18Occuped = false;

    public bool Emplacement3Full = false;


    //EMPLACEMENT 4
    public GameObject Slot19;
    public bool Solt19Occuped = false;
    public GameObject Slot20;
    public bool Solt20Occuped = false;
    public GameObject Slot21;
    public bool Solt21Occuped = false;
    public GameObject Slot22;
    public bool Solt22Occuped = false;
    public GameObject Slot23;
    public bool Solt23Occuped = false;
    public GameObject Slot24;
    public bool Solt24Occuped = false;

    public bool Emplacement4Full = false;


    //EMPLACEMENT 5
    public GameObject Slot25;
    public bool Solt25Occuped = false;
    public GameObject Slot26;
    public bool Solt26Occuped = false;
    public GameObject Slot27;
    public bool Solt27Occuped = false;
    public GameObject Slot28;
    public bool Solt28Occuped = false;
    public GameObject Slot29;
    public bool Solt29Occuped = false;
    public GameObject Slot30;
    public bool Solt30Occuped = false;

    public bool Emplacement5Full = false;


    //EMPLACEMENT 6
    public GameObject Slot31;
    public bool Solt31Occuped = false;
    public GameObject Slot32;
    public bool Solt32Occuped = false;
    public GameObject Slot33;
    public bool Solt33Occuped = false;
    public GameObject Slot34;
    public bool Solt34Occuped = false;
    public GameObject Slot35;
    public bool Solt35Occuped = false;
    public GameObject Slot36;
    public bool Solt36Occuped = false;

    public bool Emplacement6Full = false;


    //EMPLACEMENT 7
    public GameObject Slot37;
    public bool Solt37Occuped = false;
    public GameObject Slot38;
    public bool Solt38Occuped = false;
    public GameObject Slot39;
    public bool Solt39Occuped = false;
    public GameObject Slot40;
    public bool Solt40Occuped = false;
    public GameObject Slot41;
    public bool Solt41Occuped = false;
    public GameObject Slot42;
    public bool Solt42Occuped = false;

    public bool Emplacement7Full = false;


    //EMPLACEMENT 8
    public GameObject Slot43;
    public bool Solt43Occuped = false;
    public GameObject Slot44;
    public bool Solt44Occuped = false;
    public GameObject Slot45;
    public bool Solt45Occuped = false;
    public GameObject Slot46;
    public bool Solt46Occuped = false;
    public GameObject Slot47;
    public bool Solt47Occuped = false;
    public GameObject Slot48;
    public bool Solt48Occuped = false;

    public bool Emplacement8Full = false;

    //RESTE

    public GameObject Player;
    public GameObject ObjetInHand;



    
    
    void Start()
  {
      
  }

    
  void Update()
  {
    ObjetInHand = Player.GetComponent<PlayerMovement>().ObjetInHand;
  }

  public void place()
  {
    
    if(Solt1Occuped == false)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot1.transform);
        
      Solt1Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }
    
    if(Solt2Occuped == false && Solt1Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot2.transform);
        
      Solt2Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;

    }

    if(Solt3Occuped == false && Solt2Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot3.transform);
        
      Solt3Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt3Occuped == false && Solt2Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot3.transform);
        
      Solt3Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt4Occuped == false && Solt3Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot4.transform);
        
      Solt4Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt5Occuped == false && Solt4Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot5.transform);
        
      Solt5Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt6Occuped == false && Solt5Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot6.transform);
        
      Solt6Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt7Occuped == false && Solt6Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot7.transform);
        
      Solt7Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt8Occuped == false && Solt7Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot8.transform);
        
      Solt8Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt9Occuped == false && Solt8Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot9.transform);
        
      Solt9Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt10Occuped == false && Solt9Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot10.transform);
        
      Solt10Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt11Occuped == false && Solt10Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot11.transform);
        
      Solt11Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt12Occuped == false && Solt11Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot12.transform);
        
      Solt12Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt13Occuped == false && Solt12Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot13.transform);
        
      Solt13Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt14Occuped == false && Solt13Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot14.transform);
        
      Solt14Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt15Occuped == false && Solt14Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot15.transform);
        
      Solt15Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt16Occuped == false && Solt15Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot16.transform);
        
      Solt16Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt17Occuped == false && Solt16Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot17.transform);
        
      Solt17Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt18Occuped == false && Solt17Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot18.transform);
        
      Solt18Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt19Occuped == false && Solt18Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot19.transform);
        
      Solt19Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt20Occuped == false && Solt19Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot20.transform);
        
      Solt20Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt21Occuped == false && Solt20Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot21.transform);
        
      Solt21Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt22Occuped == false && Solt21Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot22.transform);
        
      Solt22Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt23Occuped == false && Solt22Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot23.transform);
        
      Solt23Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt24Occuped == false && Solt23Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot24.transform);
        
      Solt24Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt25Occuped == false && Solt24Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot25.transform);
        
      Solt25Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt26Occuped == false && Solt25Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot26.transform);
        
      Solt26Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt27Occuped == false && Solt26Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot27.transform);
        
      Solt27Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt28Occuped == false && Solt27Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot28.transform);
        
      Solt28Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt29Occuped == false && Solt28Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot29.transform);
        
      Solt29Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt30Occuped == false && Solt29Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot30.transform);
        
      Solt30Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt31Occuped == false && Solt30Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot31.transform);
        
      Solt31Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt32Occuped == false && Solt31Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot32.transform);
        
      Solt32Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt33Occuped == false && Solt32Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot33.transform);
        
      Solt33Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt34Occuped == false && Solt33Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot34.transform);
        
      Solt34Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt35Occuped == false && Solt34Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot35.transform);
        
      Solt35Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt36Occuped == false && Solt35Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot36.transform);
        
      Solt36Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt37Occuped == false && Solt36Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot37.transform);
        
      Solt37Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt38Occuped == false && Solt37Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot38.transform);
        
      Solt38Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt39Occuped == false && Solt38Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot39.transform);
        
      Solt39Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt40Occuped == false && Solt39Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot40.transform);
        
      Solt40Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt41Occuped == false && Solt40Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot41.transform);
        
      Solt41Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt42Occuped == false && Solt41Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot42.transform);
        
      Solt42Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt43Occuped == false && Solt42Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot43.transform);
        
      Solt43Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt44Occuped == false && Solt43Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot44.transform);
        
      Solt44Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt45Occuped == false && Solt44Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot45.transform);
        
      Solt45Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt46Occuped == false && Solt45Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot46.transform);
        
      Solt46Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt46Occuped == false && Solt45Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot46.transform);
        
      Solt46Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt47Occuped == false && Solt46Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot47.transform);
        
      Solt47Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

    if(Solt48Occuped == false && Solt47Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot48.transform);
        
      Solt48Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      return;
    }

  }

  public void take()
  {
    Debug.Log("Take");
  }

}
