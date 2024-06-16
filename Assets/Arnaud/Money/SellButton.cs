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
    public GameManager GameManager;

    public float itemPrice = 0f;
    
    float BPrice;

    


    void Start()
    {
       
    }

    
    void Update()
    {
      

        
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
