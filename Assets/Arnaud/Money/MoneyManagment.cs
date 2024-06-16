using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManagment : MonoBehaviour
{

    public float Money = 0;
    public TMP_Text MoneyTxt;
    public TMP_Text MoneyTxt2;
    
    void Update()
    {
        MoneyTxt.text = "Monux :" + Money;
        MoneyTxt2.text = "Monux :" + Money;
        
    }

    public void Encaissement()
    {
        
    }
  

    
}
