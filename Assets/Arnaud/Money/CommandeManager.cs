using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandeManager : MonoBehaviour
{
    public List<GameObject> Commande = new List<GameObject>();
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void AddGameObject(GameObject newObject)
    {
        Commande.Add(newObject);
    }
}
