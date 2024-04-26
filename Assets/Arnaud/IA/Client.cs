using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Client : MonoBehaviour
{
    private NavMeshAgent client;
    private Transform Armoire;

    void Start()
    {
        client = GetComponent<NavMeshAgent>();
        Armoire = FindObjectOfType<PointRetrait>().transform;
        
    }

   
    void Update()
    {
        client.SetDestination(Armoire.position);
    }
}
