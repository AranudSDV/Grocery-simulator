using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PcManager : MonoBehaviour
{
    public GameObject BouttonMetero;
    public GameObject MeteroSite;
    public GameObject PanierMeteroSite;



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
}
