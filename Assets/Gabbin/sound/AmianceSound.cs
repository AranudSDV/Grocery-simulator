using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmianceSound : MonoBehaviour
{
    public Collider Area;
    public GameObject Player;

    void Update()
    {
        //localiser la collision entre le trigger et le joueur
        Vector3 closestPoint = Area.ClosestPoint(Player.transform.position);
        transform.position = closestPoint;
    }
}
