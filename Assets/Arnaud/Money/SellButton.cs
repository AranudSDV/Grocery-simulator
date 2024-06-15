using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SellButton : MonoBehaviour
{

    public GameObject item;
    public MoneyManagment MoneyManager;
    public SpriteRenderer Icon;
    public GameObject Spawn;

    public float itemPrice = 0f;
    

    //public TMP_Text PriceTxt;
    float BPrice;

    
    


    
    void Start()
    {
        
    }

    
    void Update()
    {

       

        //BPrice = itemPrice;
        //string SPrice = BPrice.ToString();
        //PriceTxt.text = SPrice;

        
    }

    public void BuyButton(GameObject prefab)
    {
        if(itemPrice <= MoneyManager.Money)
        {
            MoneyManager.Money = MoneyManager.Money - itemPrice;
            Instantiate(prefab, new Vector3(15 ,2 ,-192), Quaternion.identity);
        }
        
    }

    
}
