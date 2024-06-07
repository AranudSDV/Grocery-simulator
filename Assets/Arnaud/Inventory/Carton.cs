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

    public MeshRenderer RenderCarton;
    public Collider ColliderCArton;
    public Rigidbody rigCarton;


    
    void Start()
    {
        
    }

    
    void Update()
    {

    }

    public void Ouverture()
    {
        positionCarton = carton.transform.position;

        StartCoroutine(cartonfx());

        for (var i = 0; i < NombreItem; i++)
        {
            Instantiate(Item,positionCarton, Quaternion.identity);
        }
        
        Destroy(RenderCarton);
        Destroy(ColliderCArton);
        Destroy(rigCarton);

    }

    IEnumerator cartonfx()
    {
        FX.SetActive(true);
        yield return new WaitForSeconds(2);
        Destroy(FX);
        Destroy(carton);
    }
}
