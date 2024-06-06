using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Caisse : MonoBehaviour
{
  public Collider lecteur;

  public TextMeshProUGUI priceItem;
  public TextMeshProUGUI txtpanierPrice;
  private TextMeshProUGUI Name;
  private string sName;

  public bool scanne = false;
  public bool itemDejaScanne = false;

  GameObject itemScanne;

  public MoneyManagment MoneyManager;

  public List<GameObject> panier = new List<GameObject>();

  public PlayerScanner PlayerScanner;


  
  

  public float Price = 0;
  public float PanierPrice = 0;
    
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

      //itemScanne.GetComponent<item>().name = sName;

      //sName = Name.text;

      itemScanne.GetComponent<item>();

      panier.Add(itemScanne);
      
      Price = itemScanne.GetComponent<item>().SellPrice;

      priceItem.text = "Prix de " + lecteur.gameObject.name + " est à " + Price;
      
      PanierPrice = PanierPrice + Price;
      
      Destroy(itemScanne.GetComponent<item>());
      scanne = false;
    }
  }

  public void Encaissement()
  {
    MoneyManager.Money = MoneyManager.Money + PanierPrice;
    PanierPrice = 0;
    priceItem.text = "";
    Debug.Log("encaissement()");

    for (int i = 0; i < panier.Count; i++)
    {
      Destroy(panier[i].gameObject);
    }

    panier.Clear();
    
    PlayerScanner.Encaisse = true;
    StartCoroutine(CaisseEncaisse());
  }

  IEnumerator CaisseEncaisse()
    {
      yield return new WaitForSeconds(1);
      PlayerScanner.Encaisse = false;
    }
  

}
