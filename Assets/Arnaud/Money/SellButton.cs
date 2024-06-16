using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SellButton : MonoBehaviour
{
    public GameObject TxtCommande;
    public GameObject item;
    public MoneyManagment MoneyManager;
    public SpriteRenderer Icon;
    public GameObject Spawn;
    private GameManager gameManager;

    public float itemPrice = 0f;
    
    float BPrice;

    bool FileAttente;

    


    void Start()
    {
       
        gameManager = FindObjectOfType<GameManager>();
        if (gameManager == null)
        {
            //Debug.LogError("GameManager non trouvé dans la scène.");
        }


        if (item == null)
        {
            //Debug.LogError("L'objet item n'est pas assigné. Assignez-le dans l'inspecteur.");
        }
        else
        {
            //Debug.Log("L'objet item est assigné correctement.");
        }
    }

    
    void Update()
    {
      if (FileAttente == true)
        {
            
            if (item != null)
            {
                gameManager.CommandeEnAttente.Add(item);
                //Debug.Log(item.name + " ajouté à la liste CommandeEnAttente.");
                FileAttente = false;
            }
            else
            {
                //Debug.LogError("L'objet item est null.");
            }
        }

        
    }

    public void BuyButton()
    {
        if(itemPrice <= MoneyManager.Money)
        {
            StartCoroutine(UICommande());
            MoneyManager.Money = MoneyManager.Money - itemPrice;
            FileAttente = true;
            //Instantiate(prefab, new Vector3(15 ,2 ,-192), Quaternion.identity);
        }

    }

    IEnumerator UICommande()
    {
        TxtCommande.SetActive(true);
        yield return new WaitForSeconds(2);
        TxtCommande.SetActive(false);

    }

}
