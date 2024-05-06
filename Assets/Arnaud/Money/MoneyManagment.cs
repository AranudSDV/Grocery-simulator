using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManagment : MonoBehaviour
{

    public float Money = 0;
    public TMP_Text MoneyTxt;
    
    void Update()
    {
        MoneyTxt.text = "Money :" + Money;
        
    }

    public void Encaissement()
    {
        
    }
  

    
}
