using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carton : MonoBehaviour
{
    public GameObject Item;

    public GameObject carton;

    public GameObject FX;

    public float NombreItem = 0;

    Vector3 positionCarton;


    
    void Start()
    {
        
    }

    
    void Update()
    {

    }

    public void Ouverture()
    {
        positionCarton = carton.transform.position;


        FX.transform.SetParent(null);
        FX.SetActive(true);

        for (var i = 0; i < NombreItem; i++)
        {
            Instantiate(Item,positionCarton, Quaternion.identity);
        }
        Destroy(carton);
    }
}
