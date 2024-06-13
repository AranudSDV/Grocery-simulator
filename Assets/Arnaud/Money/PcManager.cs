using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PcManager : MonoBehaviour
{
    public GameObject BouttonMetero;
    public GameObject MeteroSite;
    public GameObject PanierMeteroSite;
    public GameObject Page_1;
    public GameObject Page_2;
    public GameObject Page_3;
    public GameObject FlecheP1;
    public GameObject FlecheP2;
    public GameObject FlecheP22;
    public GameObject FlecheP3;

    public GameObject Page2Lock;
    public GameObject Page3Lock;
    public GameObject FlecheDD2Lock;
    public GameObject FlecheDD3Lock;
    public GameObject FlecheGD2Lock;
   


    public GameObject BouttonLVLUP;
    public GameObject LvlupSite;
    public GameObject LvlUpMagasin;
    public GameObject LvlUpArticles;
    public GameObject LvlUpVente;
    public GameObject LvlUpPNJ;
    public GameObject LvlUpPUB;
    public GameObject LvlUpStockage;

    public GameObject Fleche_LVLUP;

    public GameObject item;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void Meterosite()
    {
        MeteroSite.SetActive(true);
    }

    public void Page1()
    {
        Page_1.SetActive(true);
        Page_2.SetActive(false);
        Page_3.SetActive(false);

        FlecheP1.SetActive(true);
        FlecheP2.SetActive(false);
        FlecheP22.SetActive(false);
        FlecheP3.SetActive(false);

    }

    public void Page2()
    {
        Page_1.SetActive(false);
        Page_2.SetActive(true);
        Page_3.SetActive(false);


        FlecheP1.SetActive(false);
        FlecheP2.SetActive(true);
        FlecheP22.SetActive(true);
        FlecheP3.SetActive(false);
    }

    public void Page3()
    {
        Page_1.SetActive(false);
        Page_2.SetActive(false);
        Page_3.SetActive(true);

        FlecheP1.SetActive(false);
        FlecheP2.SetActive(false);
        FlecheP22.SetActive(false);
        FlecheP3.SetActive(true);
    }

    public void Page2LockF()
    {
        Page2Lock.SetActive(true);
        Page_1.SetActive(false);
    }

    public void Page3LockF()
    {
        Page3Lock.SetActive(true);
        Page2Lock.SetActive(false);
        Page_1.SetActive(false);
    }

    public void QuitMETOROR()
    {
        Page_1.SetActive(false);
        Page_2.SetActive(false);
        Page_3.SetActive(false);

        FlecheP1.SetActive(false);
        FlecheP2.SetActive(false);
        FlecheP22.SetActive(false);
        FlecheP3.SetActive(false);
        MeteroSite.SetActive(false);
    }
        
    

    public void Lvlupsite()
    {
        LvlupSite.SetActive(true);
    }

    public void LVLUP_Magasin()
    {
        LvlUpMagasin.SetActive(true);
        LvlUpArticles.SetActive(false);
        LvlUpVente.SetActive(false);
        LvlUpPNJ.SetActive(false);
        LvlUpPUB.SetActive(false);
        LvlUpStockage.SetActive(false);
    }

    public void LVLUP_Articles()
    {
        LvlUpArticles.SetActive(true);
        LvlUpMagasin.SetActive(false);
        LvlUpVente.SetActive(false);
        LvlUpPNJ.SetActive(false);
        LvlUpPUB.SetActive(false);
        LvlUpStockage.SetActive(false);
    }

    public void LVLUP_Vente()
    {
        LvlUpVente.SetActive(true);
        LvlUpMagasin.SetActive(false);
        LvlUpArticles.SetActive(false);
        LvlUpPNJ.SetActive(false);
        LvlUpPUB.SetActive(false);
        LvlUpStockage.SetActive(false);
    }

    public void LVLUP_PNJ()
    {
        LvlUpPNJ.SetActive(true);
        LvlUpMagasin.SetActive(false);
        LvlUpArticles.SetActive(false);
        LvlUpVente.SetActive(false);
        LvlUpPUB.SetActive(false);
        LvlUpStockage.SetActive(false);
    }

    public void LVLUP_PUB()
    {
        LvlUpPUB.SetActive(true);
        LvlUpMagasin.SetActive(false);
        LvlUpArticles.SetActive(false);
        LvlUpVente.SetActive(false);
        LvlUpPNJ.SetActive(false);
        LvlUpStockage.SetActive(false);
    }

    public void LVLUP_Stockage()
    {
        LvlUpStockage.SetActive(true);
        LvlUpMagasin.SetActive(false);
        LvlUpArticles.SetActive(false);
        LvlUpVente.SetActive(false);
        LvlUpPNJ.SetActive(false);
        LvlUpPUB.SetActive(false);
    }

    public void TEST()
    {
        Instantiate(item, new Vector3(0 ,0 ,0), Quaternion.identity);
    }

    
}
