using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorTile : Tile
{
    Functions func = new Functions();

    private void Awake()
    {
        // Log every object on the position of the Belt
        foreach (var obj in func.GetObjectsOnMyPosition(gameObject)) { Debug.Log(obj); }
    }
}
