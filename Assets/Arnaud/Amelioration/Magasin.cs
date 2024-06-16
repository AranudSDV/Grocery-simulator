using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magasin : MonoBehaviour
{
    public GameObject UpMagasin1;
    public GameObject UpMagasin2;

    public GameObject FleshLock2;
    public GameObject FleshLockPage2DLock;
    public GameObject FleshLockPage3GD2;

    public GameObject FleshLock3;

    public GameManager GameManager;

    public Caisse Caisse;
    public GameObject PorteStockage;

    public MoneyManagment MoneyManager;

    public GameObject GOMagasin1;
    public GameObject GOMagasin2;
    public GameObject GOObjectCommande2;
    public GameObject GOObjectCommande3;
    public GameObject GOPUB1;
    public GameObject GOPUB2;
    public GameObject GOVente1;
    public GameObject GOVente2;
    public GameObject GOVente3;
    public GameObject GOStockage;


    public void Magasin1()
    {
        if(MoneyManager.Money > 450)
        {
            MoneyManager.Money = MoneyManager.Money - 450;
            UpMagasin1.SetActive(false);
            Destroy(GOMagasin1);
        }
        
    }

    public void Magasin2()
    {
        if(MoneyManager.Money > 500)
        {
            MoneyManager.Money = MoneyManager.Money - 500;
            UpMagasin2.SetActive(false);
            Destroy(GOMagasin2);

        }
        
    }

    public void ObjetCommande2()
    {
        if(MoneyManager.Money > 450)
        {
            MoneyManager.Money = MoneyManager.Money - 450;
            Destroy(FleshLock2);
            Destroy(FleshLockPage3GD2);
            Destroy(GOObjectCommande2);
        }
        
    }

    public void ObjetCommande3()
    {
        if(MoneyManager.Money > 500)
        {
            MoneyManager.Money = MoneyManager.Money - 500;
            Destroy(FleshLock3);
            Destroy(FleshLockPage2DLock);
            Destroy(GOObjectCommande3);
        }
        
    }

    public void PUB1()
    {
        if(MoneyManager.Money > 400)
        {
            MoneyManager.Money = MoneyManager.Money - 400;
            GameManager.numberOfClients = GameManager.numberOfClients + 2;
            Destroy(GOPUB1);
        }
        
    }

    public void PUB2()
    {
        if(MoneyManager.Money > 500)
        {
            MoneyManager.Money = MoneyManager.Money - 500;
            GameManager.numberOfClients = GameManager.numberOfClients + 3;
            Destroy(GOPUB2);
        }
        
    }

    public void Vente1()
    {
        if(MoneyManager.Money > 400)
        {
            MoneyManager.Money = MoneyManager.Money - 400;
            Caisse.MultipcateurPrice = Caisse.MultipcateurPrice * 1.05f;
            Destroy(GOVente1);
            
        }
    }

    public void Vente2()
    {
        if(MoneyManager.Money > 500)
        {
            MoneyManager.Money = MoneyManager.Money - 500;
            Caisse.MultipcateurPrice = 1;
            Caisse.MultipcateurPrice = Caisse.MultipcateurPrice * 1.10f;
            Destroy(GOVente2);
        }
        
        
    }

    public void Vente3()
    {
        if(MoneyManager.Money > 600)
        {
            MoneyManager.Money = MoneyManager.Money - 600;
            Caisse.MultipcateurPrice = 1;
            Caisse.MultipcateurPrice = Caisse.MultipcateurPrice * 1.20f;
            Destroy(GOVente3);
        }
        
        
    }

    public void Stockage()
    {
        if(MoneyManager.Money > 450)
        {
            MoneyManager.Money = MoneyManager.Money - 450;
            Destroy(PorteStockage);
            Destroy(GOStockage);
        }
        
    }

}
