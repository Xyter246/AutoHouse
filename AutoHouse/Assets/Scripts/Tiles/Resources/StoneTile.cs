using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneTile : ResourceTile 
{
    [SerializeField] private Tile _stoneMinerTile;
    new protected void OnMouseDown()
    {
        PlaceMinerType(_stoneMinerTile);
    }
}