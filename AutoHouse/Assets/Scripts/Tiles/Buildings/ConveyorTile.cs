using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorTile : Tile
{
    Functions fun = new Functions();

    //private void Update()
    //{
    //    if (func.CheckPositionRelative(0, 0)[] > 1) {

    //    }
    //}

    private void Awake()
    {
        Debug.Log(fun.CheckMyPosition());
    }
}
