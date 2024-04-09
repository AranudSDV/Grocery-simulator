using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SellButton : MonoBehaviour
{

    public Item item;
    public MoneyManagment MoneyManager;
    public SpriteRenderer image;
    

    public TMP_Text PriceTxt;
    float BPrice;
    
    


    
    void Start()
    {
        
    }

    
    void Update()
    {

        BPrice = item.BuyPrice;
        string SPrice = BPrice.ToString();
        PriceTxt.text = SPrice;
        image.sprite = item.icon;

        
    }

    public void BuyButton(GameObject prefab)
    {
        if(item.BuyPrice <= MoneyManager.Money)
        {
            MoneyManager.Money = MoneyManager.Money - item.BuyPrice;
            Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);
        }
        
    }

    
}
