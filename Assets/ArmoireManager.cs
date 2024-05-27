using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmoireManager : MonoBehaviour
{



  public Armoire[] armoires;

    
    public Armoire GetRandomNonEmptyShelf()
    {
        List<Armoire> nonEmptyShelves = new List<Armoire>();

        foreach (Armoire armoire in armoires)
        {
            if (!armoire.ArmoireHaveItem)
            {
                nonEmptyShelves.Add(armoire);
            }
        }

        if (nonEmptyShelves.Count > 0)
        {
            int randomIndex = Random.Range(0, nonEmptyShelves.Count);
            return nonEmptyShelves[randomIndex];
        }
        else
        {
            return null;  // Retourne null s'il n'y a pas d'armoire non vide
        }
    }

    
}
