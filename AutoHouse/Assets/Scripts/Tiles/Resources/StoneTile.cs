using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneTile : ResourceTile 
{
    [SerializeField] private Tile _stoneMinerTile;
    new protected void OnMouseDown()
    {
        // Place corresponding Miner Sort
        PlaceMinerType(_stoneMinerTile);
    }
}