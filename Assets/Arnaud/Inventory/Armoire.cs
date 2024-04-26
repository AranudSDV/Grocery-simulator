using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armoire : MonoBehaviour
{
    
    public static Armoire Armoireinstance;

    #region Singleton

    void Awake()
    {
        if (Armoireinstance != null)
        {
            Debug.LogWarning("plusieurs inventaire trouve");
            return;
        }
        Armoireinstance = this;
    }

    #endregion

    List<Item> items = new List<Item>();

    public void Add (Item item)
    {
        items.Add(item);
    
    }

    public void Remove (Item item)
    {
        items.Remove(item);
    }

    public bool HasObject(string objectName)
    {
        for(int i = 0; i < items.Count; i++)
        {
            if(items[i].name == objectName) return true;
        }
        return false;
    }
}
