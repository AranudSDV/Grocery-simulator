using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armoire : MonoBehaviour
{
    //EMPLACEMENT 1
    public GameObject Slot1;
    public bool Solt1Occuped = false;
    public GameObject ItemSlot1;

    public GameObject Slot2;
    public bool Solt2Occuped = false;
    public GameObject ItemSlot2;

    public GameObject Slot3;
    public bool Solt3Occuped = false;
    public GameObject ItemSlot3;

    public GameObject Slot4;
    public bool Solt4Occuped = false;
    public GameObject ItemSlot4;

    public GameObject Slot5;
    public bool Solt5Occuped = false;
    public GameObject ItemSlot5;

    public GameObject Slot6;
    public bool Solt6Occuped = false;
    public GameObject ItemSlot6;

    //EMPLACEMENT 2
    public GameObject Slot7;
    public bool Solt7Occuped = false;
    public GameObject ItemSlot7;

    public GameObject Slot8;
    public bool Solt8Occuped = false;
    public GameObject ItemSlot8;

    public GameObject Slot9;
    public bool Solt9Occuped = false;
    public GameObject ItemSlot9;

    public GameObject Slot10;
    public bool Solt10Occuped = false;
    public GameObject ItemSlot10;

    public GameObject Slot11;
    public bool Solt11Occuped = false;
    public GameObject ItemSlot11;

    public GameObject Slot12;
    public bool Solt12Occuped = false;
    public GameObject ItemSlot12;

    //EMPLACEMENT 3
    public GameObject Slot13;
    public bool Solt13Occuped = false;
    public GameObject ItemSlot13;

    public GameObject Slot14;
    public bool Solt14Occuped = false;
    public GameObject ItemSlot14;

    public GameObject Slot15;
    public bool Solt15Occuped = false;
    public GameObject ItemSlot15;

    public GameObject Slot16;
    public bool Solt16Occuped = false;
    public GameObject ItemSlot16;

    public GameObject Slot17;
    public bool Solt17Occuped = false;
    public GameObject ItemSlot17;

    public GameObject Slot18;
    public bool Solt18Occuped = false;
    public GameObject ItemSlot18;

    //EMPLACEMENT 4
    public GameObject Slot19;
    public bool Solt19Occuped = false;
    public GameObject ItemSlot19;

    public GameObject Slot20;
    public bool Solt20Occuped = false;
    public GameObject ItemSlot20;

    public GameObject Slot21;
    public bool Solt21Occuped = false;
    public GameObject ItemSlot21;

    public GameObject Slot22;
    public bool Solt22Occuped = false;
    public GameObject ItemSlot22;

    public GameObject Slot23;
    public bool Solt23Occuped = false;
    public GameObject ItemSlot23;

    public GameObject Slot24;
    public bool Solt24Occuped = false;
    public GameObject ItemSlot24;

    //EMPLACEMENT 5
    public GameObject Slot25;
    public bool Solt25Occuped = false;
    public GameObject ItemSlot25;

    public GameObject Slot26;
    public bool Solt26Occuped = false;
    public GameObject ItemSlot26;

    public GameObject Slot27;
    public bool Solt27Occuped = false;
    public GameObject ItemSlot27;

    public GameObject Slot28;
    public bool Solt28Occuped = false;
    public GameObject ItemSlot28;

    public GameObject Slot29;
    public bool Solt29Occuped = false;
    public GameObject ItemSlot29;

    public GameObject Slot30;
    public bool Solt30Occuped = false;
    public GameObject ItemSlot30;

    //EMPLACEMENT 6
    public GameObject Slot31;
    public bool Solt31Occuped = false;
    public GameObject ItemSlot31;

    public GameObject Slot32;
    public bool Solt32Occuped = false;
    public GameObject ItemSlot32;

    public GameObject Slot33;
    public bool Solt33Occuped = false;
    public GameObject ItemSlot33;

    public GameObject Slot34;
    public bool Solt34Occuped = false;
    public GameObject ItemSlot34;

    public GameObject Slot35;
    public bool Solt35Occuped = false;
    public GameObject ItemSlot35;

    public GameObject Slot36;
    public bool Solt36Occuped = false;
    public GameObject ItemSlot36;

    //EMPLACEMENT 7
    public GameObject Slot37;
    public bool Solt37Occuped = false;
    public GameObject ItemSlot37;

    public GameObject Slot38;
    public bool Solt38Occuped = false;
    public GameObject ItemSlot38;

    public GameObject Slot39;
    public bool Solt39Occuped = false;
    public GameObject ItemSlot39;

    public GameObject Slot40;
    public bool Solt40Occuped = false;
    public GameObject ItemSlot40;

    public GameObject Slot41;
    public bool Solt41Occuped = false;
    public GameObject ItemSlot41;

    public GameObject Slot42;
    public bool Solt42Occuped = false;
    public GameObject ItemSlot42;

    //EMPLACEMENT 8
    public GameObject Slot43;
    public bool Solt43Occuped = false;
    public GameObject ItemSlot43;

    public GameObject Slot44;
    public bool Solt44Occuped = false;
    public GameObject ItemSlot44;

    public GameObject Slot45;
    public bool Solt45Occuped = false;
    public GameObject ItemSlot45;

    public GameObject Slot46;
    public bool Solt46Occuped = false;
    public GameObject ItemSlot46;

    public GameObject Slot47;
    public bool Solt47Occuped = false;
    public GameObject ItemSlot47;

    public GameObject Slot48;
    public bool Solt48Occuped = false;
    public GameObject ItemSlot48;

    //RESTE

    public GameObject Player;
    public GameObject ObjetInHand;
    public GameObject ObjectTake;
    public ItemPickup ItemPickup;

    
    GameObject client;

    public bool EstVide = false;

    public List<GameObject> ItemInArmoire = new List<GameObject>();

    public GameObject RecupPoint;

    
    
    

    
    
    void Start()
  {
    
  }

    
  void Update()
  {
    ObjetInHand = Player.GetComponent<PlayerMovement>().ObjetInHand;

    if( Solt1Occuped == true || Solt2Occuped == true || Solt3Occuped == true || Solt4Occuped == true || Solt5Occuped == true || Solt6Occuped == true || Solt7Occuped == true || Solt8Occuped == true || Solt9Occuped == true || Solt10Occuped == true || Solt11Occuped == true || Solt12Occuped == true || Solt13Occuped == true || Solt14Occuped == true || Solt15Occuped == true || Solt16Occuped == true || Solt17Occuped == true || Solt18Occuped == true || Solt19Occuped == true || Solt20Occuped == true || Solt21Occuped == true || Solt22Occuped == true || Solt23Occuped == true || Solt23Occuped == true || Solt24Occuped == true || Solt25Occuped == true || Solt26Occuped == true || Solt27Occuped == true || Solt28Occuped == true || Solt29Occuped == true || Solt30Occuped == true || Solt31Occuped == true || Solt32Occuped == true || Solt33Occuped == true || Solt34Occuped == true || Solt35Occuped == true || Solt36Occuped == true || Solt37Occuped == true || Solt38Occuped == true || Solt39Occuped == true || Solt40Occuped == true || Solt41Occuped == true || Solt42Occuped == true || Solt43Occuped == true || Solt44Occuped == true || Solt45Occuped == true || Solt46Occuped == true || Solt47Occuped == true || Solt48Occuped == true)
    {
      EstVide = false;
    }
    else
    {
      EstVide = true;
    }
  }

  

  

  public void place()
  {
    
    if(Solt1Occuped == false)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot1.transform);
      
        
      Solt1Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot1 = ObjetInHand;
      ItemInArmoire.RemoveAt(1);
      ItemInArmoire.Insert(1, ItemSlot1);
      return;
    }
    
    if(Solt2Occuped == false && Solt1Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot2.transform);
        
      Solt2Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot2 = ObjetInHand;
      ItemInArmoire.RemoveAt(2);
      ItemInArmoire.Insert(2, ItemSlot2);

      return;

    }

    if(Solt3Occuped == false && Solt2Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot3.transform);
        
      Solt3Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot3 = ObjetInHand;
      ItemInArmoire.RemoveAt(3);
      ItemInArmoire.Insert(3, ItemSlot3);

      return;
    }


    if(Solt4Occuped == false && Solt3Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot4.transform);
        
      Solt4Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot4 = ObjetInHand;
      ItemInArmoire.RemoveAt(4);
      ItemInArmoire.Insert(4, ItemSlot4);


      return;
    }

    if(Solt5Occuped == false && Solt4Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot5.transform);
        
      Solt5Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot5 = ObjetInHand;
      ItemInArmoire.RemoveAt(5);
      ItemInArmoire.Insert(5, ItemSlot5);
      return;
    }

    if(Solt6Occuped == false && Solt5Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot6.transform);
        
      Solt6Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot6 = ObjetInHand;
      ItemInArmoire.RemoveAt(6);
      ItemInArmoire.Insert(6, ItemSlot6);


      return;
    }

    if(Solt7Occuped == false && Solt6Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot7.transform);
        
      Solt7Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot7 = ObjetInHand;
      ItemInArmoire.RemoveAt(7);
      ItemInArmoire.Insert(7, ItemSlot7);


      return;
    }

    if(Solt8Occuped == false && Solt7Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot8.transform);
        
      Solt8Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot8 = ObjetInHand;
      ItemInArmoire.RemoveAt(8);
      ItemInArmoire.Insert(8, ItemSlot8);


      return;
    }

    if(Solt9Occuped == false && Solt8Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot9.transform);
        
      Solt9Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot9 = ObjetInHand;
      ItemInArmoire.RemoveAt(9);
      ItemInArmoire.Insert(9, ItemSlot9);


      return;
    }

    if(Solt10Occuped == false && Solt9Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot10.transform);
        
      Solt10Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot10 = ObjetInHand;
      ItemInArmoire.RemoveAt(10);
      ItemInArmoire.Insert(10, ItemSlot10);

      return;
    }

    if(Solt11Occuped == false && Solt10Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot11.transform);
        
      Solt11Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot11 = ObjetInHand;
      ItemInArmoire.RemoveAt(1);
      ItemInArmoire.Insert(11, ItemSlot11);


      return;
    }

    if(Solt12Occuped == false && Solt11Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot12.transform);
        
      Solt12Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot12 = ObjetInHand;
      ItemInArmoire.RemoveAt(12);
      ItemInArmoire.Insert(12, ItemSlot12);


      return;
    }

    if(Solt13Occuped == false && Solt12Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot13.transform);
        
      Solt13Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot13 = ObjetInHand;
      ItemInArmoire.RemoveAt(13);
      ItemInArmoire.Insert(13, ItemSlot13);


      return;
    }

    if(Solt14Occuped == false && Solt13Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot14.transform);
        
      Solt14Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot14 = ObjetInHand;
      ItemInArmoire.RemoveAt(14);
      ItemInArmoire.Insert(14, ItemSlot14);


      return;
    }

    if(Solt15Occuped == false && Solt14Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot15.transform);
        
      Solt15Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot15 = ObjetInHand;
      ItemInArmoire.RemoveAt(15);
      ItemInArmoire.Insert(15, ItemSlot15);


      return;
    }

    if(Solt16Occuped == false && Solt15Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot16.transform);
        
      Solt16Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot16 = ObjetInHand;
      ItemInArmoire.RemoveAt(16);
      ItemInArmoire.Insert(16, ItemSlot16);


      return;
    }

    if(Solt17Occuped == false && Solt16Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot17.transform);
        
      Solt17Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot17 = ObjetInHand;
      ItemInArmoire.RemoveAt(17);
      ItemInArmoire.Insert(17, ItemSlot17);


      return;
    }

    if(Solt18Occuped == false && Solt17Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot18.transform);
        
      Solt18Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot18 = ObjetInHand;
      ItemInArmoire.RemoveAt(18);
      ItemInArmoire.Insert(18, ItemSlot18);


      return;
    }

    if(Solt19Occuped == false && Solt18Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot19.transform);
        
      Solt19Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot19 = ObjetInHand;
      ItemInArmoire.RemoveAt(19);
      ItemInArmoire.Insert(19, ItemSlot19);


      return;
    }

    if(Solt20Occuped == false && Solt19Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot20.transform);
        
      Solt20Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot20 = ObjetInHand;
      ItemInArmoire.RemoveAt(2);
      ItemInArmoire.Insert(20, ItemSlot20);


      return;
    }

    if(Solt21Occuped == false && Solt20Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot21.transform);
        
      Solt21Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot21 = ObjetInHand;
      ItemInArmoire.RemoveAt(2);
      ItemInArmoire.Insert(21, ItemSlot21);

      return;
    }

    if(Solt22Occuped == false && Solt21Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot22.transform);
        
      Solt22Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot22 = ObjetInHand;
      ItemInArmoire.RemoveAt(22);
      ItemInArmoire.Insert(22, ItemSlot22);

      return;
    }

    if(Solt23Occuped == false && Solt22Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot23.transform);
        
      Solt23Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot23 = ObjetInHand;
      ItemInArmoire.RemoveAt(23);
      ItemInArmoire.Insert(23, ItemSlot23);

      return;
    }

    if(Solt24Occuped == false && Solt23Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot24.transform);
        
      Solt24Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot24 = ObjetInHand;
      ItemInArmoire.RemoveAt(24);
      ItemInArmoire.Insert(24, ItemSlot24);

      return;
    }

    if(Solt25Occuped == false && Solt24Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot25.transform);
        
      Solt25Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot25 = ObjetInHand;
      ItemInArmoire.RemoveAt(25);
      ItemInArmoire.Insert(25, ItemSlot25);

      return;
    }

    if(Solt26Occuped == false && Solt25Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot26.transform);
        
      Solt26Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot26 = ObjetInHand;
      ItemInArmoire.RemoveAt(26);
      ItemInArmoire.Insert(26, ItemSlot26);

      return;
    }

    if(Solt27Occuped == false && Solt26Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot27.transform);
        
      Solt27Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot27 = ObjetInHand;
      ItemInArmoire.RemoveAt(27);
      ItemInArmoire.Insert(27, ItemSlot27);

      return;
    }

    if(Solt28Occuped == false && Solt27Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot28.transform);
        
      Solt28Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot28 = ObjetInHand;
      ItemInArmoire.RemoveAt(28);
      ItemInArmoire.Insert(28, ItemSlot28);

      return;
    }

    if(Solt29Occuped == false && Solt28Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot29.transform);
        
      Solt29Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot29 = ObjetInHand;
      ItemInArmoire.RemoveAt(29);
      ItemInArmoire.Insert(29, ItemSlot29);

      return;
    }

    if(Solt30Occuped == false && Solt29Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot30.transform);
        
      Solt30Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot30 = ObjetInHand;
      ItemInArmoire.RemoveAt(30);
      ItemInArmoire.Insert(30, ItemSlot30);

      return;
    }

    if(Solt31Occuped == false && Solt30Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot31.transform);
        
      Solt31Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot31 = ObjetInHand;
      ItemInArmoire.RemoveAt(31);
      ItemInArmoire.Insert(31, ItemSlot31);

      return;
    }

    if(Solt32Occuped == false && Solt31Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot32.transform);
        
      Solt32Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot32 = ObjetInHand;
      ItemInArmoire.RemoveAt(32);
      ItemInArmoire.Insert(32, ItemSlot32);

      return;
    }

    if(Solt33Occuped == false && Solt32Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot33.transform);
        
      Solt33Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot33 = ObjetInHand;
      ItemInArmoire.RemoveAt(33);
      ItemInArmoire.Insert(33, ItemSlot33);

      return;
    }

    if(Solt34Occuped == false && Solt33Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot34.transform);
        
      Solt34Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot34 = ObjetInHand;
      ItemInArmoire.RemoveAt(34);
      ItemInArmoire.Insert(34, ItemSlot34);

      return;
    }

    if(Solt35Occuped == false && Solt34Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot35.transform);
        
      Solt35Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot35 = ObjetInHand;
      ItemInArmoire.RemoveAt(35);
      ItemInArmoire.Insert(35, ItemSlot35);

      return;
    }

    if(Solt36Occuped == false && Solt35Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot36.transform);
        
      Solt36Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot36 = ObjetInHand;
      ItemInArmoire.RemoveAt(36);
      ItemInArmoire.Insert(36, ItemSlot36);

      return;
    }

    if(Solt37Occuped == false && Solt36Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot37.transform);
        
      Solt37Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot37 = ObjetInHand;
      ItemInArmoire.RemoveAt(37);
      ItemInArmoire.Insert(37, ItemSlot37);

      return;
    }

    if(Solt38Occuped == false && Solt37Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot38.transform);
        
      Solt38Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot38 = ObjetInHand;
      ItemInArmoire.RemoveAt(38);
      ItemInArmoire.Insert(38, ItemSlot38);

      return;
    }

    if(Solt39Occuped == false && Solt38Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot39.transform);
        
      Solt39Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot39 = ObjetInHand;
      ItemInArmoire.RemoveAt(39);
      ItemInArmoire.Insert(39, ItemSlot39);

      return;
    }

    if(Solt40Occuped == false && Solt39Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot40.transform);
        
      Solt40Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot40 = ObjetInHand;
      ItemInArmoire.RemoveAt(40);
      ItemInArmoire.Insert(40, ItemSlot40);

      return;
    }

    if(Solt41Occuped == false && Solt40Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot41.transform);
        
      Solt41Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot41 = ObjetInHand;
      ItemInArmoire.RemoveAt(41);
      ItemInArmoire.Insert(41, ItemSlot41);

      return;
    }

    if(Solt42Occuped == false && Solt41Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot42.transform);
        
      Solt42Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot42 = ObjetInHand;
      ItemInArmoire.RemoveAt(42);
      ItemInArmoire.Insert(42, ItemSlot42);

      return;
    }

    if(Solt43Occuped == false && Solt42Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot43.transform);
        
      Solt43Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot43 = ObjetInHand;
      ItemInArmoire.RemoveAt(43);
      ItemInArmoire.Insert(43, ItemSlot43);

      return;
    }

    if(Solt44Occuped == false && Solt43Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot44.transform);
        
      Solt44Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot44 = ObjetInHand;
      ItemInArmoire.RemoveAt(44);
      ItemInArmoire.Insert(44, ItemSlot44);

      return;
    }

    if(Solt45Occuped == false && Solt44Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot45.transform);
        
      Solt45Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot45 = ObjetInHand;
      ItemInArmoire.RemoveAt(45);
      ItemInArmoire.Insert(45, ItemSlot45);

      return;
    }

    if(Solt46Occuped == false && Solt45Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot46.transform);
        
      Solt46Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot46 = ObjetInHand;
      ItemInArmoire.RemoveAt(46);
      ItemInArmoire.Insert(46, ItemSlot46);

      return;
    }

    if(Solt47Occuped == false && Solt46Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot47.transform);
        
      Solt47Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot47 = ObjetInHand;
      ItemInArmoire.RemoveAt(47);
      ItemInArmoire.Insert(47, ItemSlot47);

      return;
    }

    if(Solt48Occuped == false && Solt47Occuped == true)
    {
      ObjetInHand.transform.localPosition = new Vector3(0f, 0f, 0f);
      ObjetInHand.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
      ObjetInHand.transform.SetParent(Slot48.transform);
        
      Solt48Occuped = true;
      Rigidbody myRigidbody = ObjetInHand.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = true;
      myRigidbody.detectCollisions = false;
      ItemSlot48 = ObjetInHand;
      ItemInArmoire.RemoveAt(48);
      ItemInArmoire.Insert(48, ItemSlot48);

      return;
    }

  }

  public void take()
  {
    if(Solt1Occuped == true)
    {
      ItemSlot1.transform.SetParent(Camera.main.transform);
      ItemSlot1.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt1Occuped = false;
      ObjectTake = ItemSlot1;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(1);
      ItemInArmoire.Insert(1, null);

      return;
    }

    if(Solt2Occuped == true)
    {
      ItemSlot2.transform.SetParent(Camera.main.transform);
      ItemSlot2.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt2Occuped = false;
      ObjectTake = ItemSlot2;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(2);
      ItemInArmoire.Insert(2, null);
      return;
    }

    if(Solt3Occuped == true)
    {
      ItemSlot3.transform.SetParent(Camera.main.transform);
      ItemSlot3.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt3Occuped = false;
      ObjectTake = ItemSlot3;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(3);
      ItemInArmoire.Insert(3, null);
      return;
    }

    if(Solt4Occuped == true)
    {
      ItemSlot4.transform.SetParent(Camera.main.transform);
      ItemSlot4.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt4Occuped = false;
      ObjectTake = ItemSlot4;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      
      ItemInArmoire.RemoveAt(4);
      ItemInArmoire.Insert(4, null);
      return;
    }

    if(Solt5Occuped == true)
    {
      ItemSlot5.transform.SetParent(Camera.main.transform);
      ItemSlot5.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt5Occuped = false;
      ObjectTake = ItemSlot5;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      
      ItemInArmoire.RemoveAt(5);
      ItemInArmoire.Insert(5, null);

      return;
    }

    if(Solt6Occuped == true)
    {
      ItemSlot6.transform.SetParent(Camera.main.transform);
      ItemSlot6.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt6Occuped = false;
      ObjectTake = ItemSlot6;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      
      ItemInArmoire.RemoveAt(6);
      ItemInArmoire.Insert(6, null);
      return;
    }

    if(Solt7Occuped == true)
    {
      ItemSlot7.transform.SetParent(Camera.main.transform);
      ItemSlot7.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt7Occuped = false;
      ObjectTake = ItemSlot7;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(7);
      ItemInArmoire.Insert(7, null);
      return;
    }

    if(Solt8Occuped == true)
    {
      ItemSlot8.transform.SetParent(Camera.main.transform);
      ItemSlot8.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt8Occuped = false;
      ObjectTake = ItemSlot8;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(8);
      ItemInArmoire.Insert(8, null);
      return;
    }

    if(Solt9Occuped == true)
    {
      ItemSlot9.transform.SetParent(Camera.main.transform);
      ItemSlot9.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt9Occuped = false;
      ObjectTake = ItemSlot9;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(9);
      ItemInArmoire.Insert(9, null);
      return;
    }

    if(Solt10Occuped == true)
    {
      ItemSlot10.transform.SetParent(Camera.main.transform);
      ItemSlot10.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt10Occuped = false;
      ObjectTake = ItemSlot10;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(10);
      ItemInArmoire.Insert(10, null);
      return;
    }

    if(Solt11Occuped == true)
    {
      ItemSlot11.transform.SetParent(Camera.main.transform);
      ItemSlot11.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt11Occuped = false;
      ObjectTake = ItemSlot11;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(11);
      ItemInArmoire.Insert(11, null);
      return;
    }

    if(Solt12Occuped == true)
    {
      ItemSlot12.transform.SetParent(Camera.main.transform);
      ItemSlot12.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt12Occuped = false;
      ObjectTake = ItemSlot12;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(12);
      ItemInArmoire.Insert(12, null);
      return;
    }

    if(Solt13Occuped == true)
    {
      ItemSlot13.transform.SetParent(Camera.main.transform);
      ItemSlot13.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt13Occuped = false;
      ObjectTake = ItemSlot13;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(13);
      ItemInArmoire.Insert(13, null);
      return;
    }

    if(Solt14Occuped == true)
    {
      ItemSlot14.transform.SetParent(Camera.main.transform);
      ItemSlot14.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt14Occuped = false;
      ObjectTake = ItemSlot14;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(14);
      ItemInArmoire.Insert(14, null);
      return;
    }

    if(Solt15Occuped == true)
    {
      ItemSlot15.transform.SetParent(Camera.main.transform);
      ItemSlot15.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt15Occuped = false;
      ObjectTake = ItemSlot15;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(15);
      ItemInArmoire.Insert(15, null);
      return;
    }

    if(Solt16Occuped == true)
    {
      ItemSlot16.transform.SetParent(Camera.main.transform);
      ItemSlot16.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt16Occuped = false;
      ObjectTake = ItemSlot16;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(16);
      ItemInArmoire.Insert(16, null);
      return;
    }

    if(Solt17Occuped == true)
    {
      ItemSlot17.transform.SetParent(Camera.main.transform);
      ItemSlot17.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt17Occuped = false;
      ObjectTake = ItemSlot17;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(17);
      ItemInArmoire.Insert(17, null);
      return;
    }

    if(Solt18Occuped == true)
    {
      ItemSlot18.transform.SetParent(Camera.main.transform);
      ItemSlot18.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt18Occuped = false;
      ObjectTake = ItemSlot18;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(18);
      ItemInArmoire.Insert(18, null);
      return;
    }

    if(Solt19Occuped == true)
    {
      ItemSlot19.transform.SetParent(Camera.main.transform);
      ItemSlot19.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt19Occuped = false;
      ObjectTake = ItemSlot19;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(19);
      ItemInArmoire.Insert(19, null);
      return;
    }

    if(Solt20Occuped == true)
    {
      ItemSlot20.transform.SetParent(Camera.main.transform);
      ItemSlot20.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt20Occuped = false;
      ObjectTake = ItemSlot20;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(20);
      ItemInArmoire.Insert(20, null);
      return;
    }

    if(Solt21Occuped == true)
    {
      ItemSlot21.transform.SetParent(Camera.main.transform);
      ItemSlot21.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt24Occuped = false;
      ObjectTake = ItemSlot21;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(21);
      ItemInArmoire.Insert(21, null);
      return;
    }

    if(Solt22Occuped == true)
    {
      ItemSlot22.transform.SetParent(Camera.main.transform);
      ItemSlot22.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt24Occuped = false;
      ObjectTake = ItemSlot24;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(22);
      ItemInArmoire.Insert(22, null);
      return;
    }

    if(Solt23Occuped == true)
    {
      ItemSlot23.transform.SetParent(Camera.main.transform);
      ItemSlot23.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt24Occuped = false;
      ObjectTake = ItemSlot23;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(23);
      ItemInArmoire.Insert(23, null);
      return;
    }

    if(Solt24Occuped == true)
    {
      ItemSlot24.transform.SetParent(Camera.main.transform);
      ItemSlot24.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt24Occuped = false;
      ObjectTake = ItemSlot24;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(24);
      ItemInArmoire.Insert(24, null);
      return;
    }

    if(Solt25Occuped == true)
    {
      ItemSlot25.transform.SetParent(Camera.main.transform);
      ItemSlot25.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt25Occuped = false;
      ObjectTake = ItemSlot25;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(25);
      ItemInArmoire.Insert(25, null);
      return;
    }

    if(Solt26Occuped == true)
    {
      ItemSlot26.transform.SetParent(Camera.main.transform);
      ItemSlot26.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt26Occuped = false;
      ObjectTake = ItemSlot26;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(26);
      ItemInArmoire.Insert(26, null);
      return;
    }

    if(Solt27Occuped == true)
    {
      ItemSlot27.transform.SetParent(Camera.main.transform);
      ItemSlot27.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt27Occuped = false;
      ObjectTake = ItemSlot27;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(27);
      ItemInArmoire.Insert(27, null);
      return;
    }

    if(Solt28Occuped == true)
    {
      ItemSlot28.transform.SetParent(Camera.main.transform);
      ItemSlot28.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt28Occuped = false;
      ObjectTake = ItemSlot28;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(28);
      ItemInArmoire.Insert(28, null);
      return;
    }

    if(Solt29Occuped == true)
    {
      ItemSlot29.transform.SetParent(Camera.main.transform);
      ItemSlot29.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt29Occuped = false;
      ObjectTake = ItemSlot29;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(29);
      ItemInArmoire.Insert(29, null);
      return;
    }

    if(Solt30Occuped == true)
    {
      ItemSlot30.transform.SetParent(Camera.main.transform);
      ItemSlot30.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt30Occuped = false;
      ObjectTake = ItemSlot30;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(30);
      ItemInArmoire.Insert(30, null);
      return;
    }

    if(Solt31Occuped == true)
    {
      ItemSlot31.transform.SetParent(Camera.main.transform);
      ItemSlot31.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt31Occuped = false;
      ObjectTake = ItemSlot31;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(31);
      ItemInArmoire.Insert(31, null);
      return;
    }

    if(Solt32Occuped == true)
    {
      ItemSlot32.transform.SetParent(Camera.main.transform);
      ItemSlot32.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt32Occuped = false;
      ObjectTake = ItemSlot32;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(32);
      ItemInArmoire.Insert(32, null);
      return;
    }

    if(Solt33Occuped == true)
    {
      ItemSlot33.transform.SetParent(Camera.main.transform);
      ItemSlot33.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt33Occuped = false;
      ObjectTake = ItemSlot33;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(33);
      ItemInArmoire.Insert(33, null);
      return;
    }

    if(Solt34Occuped == true)
    {
      ItemSlot34.transform.SetParent(Camera.main.transform);
      ItemSlot34.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt34Occuped = false;
      ObjectTake = ItemSlot34;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(34);
      ItemInArmoire.Insert(34, null);
      return;
    }

    if(Solt35Occuped == true)
    {
      ItemSlot35.transform.SetParent(Camera.main.transform);
      ItemSlot35.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt35Occuped = false;
      ObjectTake = ItemSlot35;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(35);
      ItemInArmoire.Insert(35, null);
      return;
    }

    if(Solt36Occuped == true)
    {
      ItemSlot36.transform.SetParent(Camera.main.transform);
      ItemSlot36.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt1Occuped = false;
      ObjectTake = ItemSlot36;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(36);
      ItemInArmoire.Insert(36, null);
      return;
    }

    if(Solt37Occuped == true)
    {
      ItemSlot37.transform.SetParent(Camera.main.transform);
      ItemSlot37.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt37Occuped = false;
      ObjectTake = ItemSlot37;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(37);
      ItemInArmoire.Insert(37, null);
      return;
    }

    if(Solt38Occuped == true)
    {
      ItemSlot38.transform.SetParent(Camera.main.transform);
      ItemSlot38.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt38Occuped = false;
      ObjectTake = ItemSlot38;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(38);
      ItemInArmoire.Insert(38, null);
      return;
    }

    if(Solt39Occuped == true)
    {
      ItemSlot39.transform.SetParent(Camera.main.transform);
      ItemSlot39.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt39Occuped = false;
      ObjectTake = ItemSlot39;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(39);
      ItemInArmoire.Insert(39, null);
      return;
    }

    if(Solt40Occuped == true)
    {
      ItemSlot40.transform.SetParent(Camera.main.transform);
      ItemSlot40.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt40Occuped = false;
      ObjectTake = ItemSlot40;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(40);
      ItemInArmoire.Insert(40, null);
      return;
    }

    if(Solt41Occuped == true)
    {
      ItemSlot41.transform.SetParent(Camera.main.transform);
      ItemSlot41.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt41Occuped = false;
      ObjectTake = ItemSlot41;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(41);
      ItemInArmoire.Insert(41, null);
      return;
    }

    if(Solt42Occuped == true)
    {
      ItemSlot42.transform.SetParent(Camera.main.transform);
      ItemSlot42.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt42Occuped = false;
      ObjectTake = ItemSlot42;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(42);
      ItemInArmoire.Insert(42, null);
      return;
    }

    if(Solt43Occuped == true)
    {
      ItemSlot43.transform.SetParent(Camera.main.transform);
      ItemSlot43.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt43Occuped = false;
      ObjectTake = ItemSlot43;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(43);
      ItemInArmoire.Insert(43, null);
      return;
    }

    if(Solt44Occuped == true)
    {
      ItemSlot44.transform.SetParent(Camera.main.transform);
      ItemSlot44.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt44Occuped = false;
      ObjectTake = ItemSlot44;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(44);
      ItemInArmoire.Insert(44, null);
      return;
    }

    if(Solt45Occuped == true)
    {
      ItemSlot45.transform.SetParent(Camera.main.transform);
      ItemSlot45.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt45Occuped = false;
      ObjectTake = ItemSlot45;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(45);
      ItemInArmoire.Insert(45, null);
      return;
    }

    if(Solt46Occuped == true)
    {
      ItemSlot46.transform.SetParent(Camera.main.transform);
      ItemSlot46.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt46Occuped = false;
      ObjectTake = ItemSlot46;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(46);
      ItemInArmoire.Insert(46, null);
      return;
    }

    if(Solt47Occuped == true)
    {
      ItemSlot47.transform.SetParent(Camera.main.transform);
      ItemSlot47.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt47Occuped = false;
      ObjectTake = ItemSlot47;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(47);
      ItemInArmoire.Insert(47, null);
      return;
    }

    if(Solt48Occuped == true)
    {
      ItemSlot48.transform.SetParent(Camera.main.transform);
      ItemSlot48.transform.localPosition = new Vector3(0f, 0f, 1f);
      Solt48Occuped = false;
      ObjectTake = ItemSlot48;

      ItemPickup.Itempickup = true;
      Rigidbody myRigidbody = ObjectTake.GetComponent<Rigidbody>();
      myRigidbody.isKinematic = false;
      myRigidbody.detectCollisions = true;
      ItemInArmoire.RemoveAt(48);
      ItemInArmoire.Insert(48, null);
      return;
    }
  }

  
  public int GetRandomOccupiedIndex()
    {
        List<int> occupiedIndices = new List<int>();

        
        for (int i = 0; i < ItemInArmoire.Count; i++)
        {
            if (ItemInArmoire[i] != null)
            {
                occupiedIndices.Add(i);
            }
        }

        
        if (occupiedIndices.Count == 0)
        {
            return -1;
        }

        
        int randomIndex = Random.Range(0, occupiedIndices.Count);
        return occupiedIndices[randomIndex];
    }
}
