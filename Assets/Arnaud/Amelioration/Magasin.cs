using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magasin : MonoBehaviour
{
    public GameObject UpMagasin1;
    public GameObject UpMagasin2;



    public void Magasin1()
    {
        UpMagasin1.SetActive(false);
    }

    public void Magasin2()
    {
        UpMagasin2.SetActive(false);
    }

}
