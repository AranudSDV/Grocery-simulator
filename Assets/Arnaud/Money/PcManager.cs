using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PcManager : MonoBehaviour
{
    public GameObject BouttonMetero;
    public GameObject MeteroSite;
    public GameObject PanierMeteroSite;
    public GameObject Page_1;


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

    public void MeterositePanier()
    {
        PanierMeteroSite.SetActive(true);
    }

    public void Page1()
    {
        Page_1.SetActive(true);
    }

    public void Page2()
    {
        Page_1.SetActive(false);
    }
}
