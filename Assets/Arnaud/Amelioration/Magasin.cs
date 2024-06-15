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


    public void Magasin1()
    {
        if(MoneyManager.Money > 450)
        {
            MoneyManager.Money = MoneyManager.Money - 450;
            UpMagasin1.SetActive(false);
        }
        
    }

    public void Magasin2()
    {
        if(MoneyManager.Money > 500)
        {
            MoneyManager.Money = MoneyManager.Money - 500;
            UpMagasin2.SetActive(false);
        }
        
    }

    public void ObjetCommande2()
    {
        if(MoneyManager.Money > 450)
        {
            MoneyManager.Money = MoneyManager.Money - 450;
            Destroy(FleshLock2);
            Destroy(FleshLockPage3GD2);
            
        }
        
    }

    public void ObjetCommande3()
    {
        if(MoneyManager.Money > 500)
        {
            MoneyManager.Money = MoneyManager.Money - 500;
            Destroy(FleshLock3);
            Destroy(FleshLockPage2DLock);
        }
        
    }

    public void PUB1()
    {
        if(MoneyManager.Money > 400)
        {
            MoneyManager.Money = MoneyManager.Money - 400;
            GameManager.numberOfClients = GameManager.numberOfClients + 2;
        }
        
    }

    public void PUB2()
    {
        if(MoneyManager.Money > 500)
        {
            MoneyManager.Money = MoneyManager.Money - 500;
            GameManager.numberOfClients = GameManager.numberOfClients + 3;
        }
        
    }

    public void Vente1()
    {
        if(MoneyManager.Money > 400)
        {
            MoneyManager.Money = MoneyManager.Money - 400;
            Caisse.MultipcateurPrice = Caisse.MultipcateurPrice * 1.05f;
            
        }
    }

    public void Vente2()
    {
        if(MoneyManager.Money > 500)
        {
            MoneyManager.Money = MoneyManager.Money - 500;
            Caisse.MultipcateurPrice = 1;
            Caisse.MultipcateurPrice = Caisse.MultipcateurPrice * 1.10f;
        }
        
        
    }

    public void Vente3()
    {
        if(MoneyManager.Money > 600)
        {
            MoneyManager.Money = MoneyManager.Money - 600;
            Caisse.MultipcateurPrice = 1;
            Caisse.MultipcateurPrice = Caisse.MultipcateurPrice * 1.20f;
        }
        
        
    }

    public void Stockage()
    {
        if(MoneyManager.Money > 450)
        {
            MoneyManager.Money = MoneyManager.Money - 450;
            Destroy(PorteStockage);
        }
        
    }

}
