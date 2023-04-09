using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorTile : ConveyorLogic
{
    private void Awake()
    {
        CheckNorth();
        CheckEast();
        CheckSouth();
        CheckWest();
    }
}
