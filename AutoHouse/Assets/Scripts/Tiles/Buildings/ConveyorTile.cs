using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorTile : Tile
{
    Functions func = new Functions();

    private void Awake()
    {
        func.CheckNorth();
        func.CheckEast();
        func.CheckSouth();
        func.CheckWest();
    }
}
