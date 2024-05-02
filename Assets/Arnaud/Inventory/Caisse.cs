using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Caisse : MonoBehaviour
{
  
  
  
  public Collider lecteur;

  public TextMeshProUGUI priceItem;
  public TextMeshProUGUI txtpanierPrice;

  public bool scanne = false;

  GameObject itemScanne;

  public MoneyManagment MoneyManager;
  
  

  float Price = 0;
  float PanierPrice = 0;
    
  void Start()
  {
      
  }

    
  void Update()
  {
    txtpanierPrice.text = "panier : " + PanierPrice;
  }

  private void OnTriggerEnter (Collider lecteur)
  {
    scanne = true;
    
    if(scanne == true)
    {
      itemScanne = lecteur.gameObject;

      itemScanne.GetComponent<item>();
      
      Price = itemScanne.GetComponent<item>().SellPrice;

      priceItem.text = "Prix de " + lecteur.gameObject.name + " est à " + Price;
      
      PanierPrice = PanierPrice + Price;
      
      itemScanne.GetComponent<item>().enabled = false;
      scanne = false;
    }
  }

  public void Encaissement()
  {
    MoneyManager.Money = MoneyManager.Money + PanierPrice;
    PanierPrice = 0;
    priceItem.text = "";
  }
  

}
