using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPrite : MonoBehaviour
{
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
  
        Vector3 cameraPosition = mainCamera.transform.position;
        Vector3 direction = cameraPosition - transform.position;

        direction.y = 0; 


        transform.rotation = Quaternion.LookRotation(-direction);
    }
}
