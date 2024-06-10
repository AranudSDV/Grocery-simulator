using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmoireManager : MonoBehaviour
{



  public Armoire[] armoires;

    
    public Armoire GetRandomNonEmptyShelf()
    {
        List<Armoire> nonEmptyShelves = new List<Armoire>();

         if (armoires == null || armoires.Length == 0)
        {
            
            return null;
        }

        foreach (Armoire armoire in armoires)
        {
            if (armoire == null)
            {
            
                continue;
            }

            if (!armoire.EstVide && !armoire.IsTargeted)
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
            return null;
        }
    }

    
}
