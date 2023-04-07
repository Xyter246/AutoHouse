using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronTile : ResourceTile 
{
    [SerializeField] private Tile _ironMinerTile;
    new protected void OnMouseDown()
    {
        PlaceMinerType(_ironMinerTile);
    }
}
