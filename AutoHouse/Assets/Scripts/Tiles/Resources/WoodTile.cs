using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodTile : ResourceTile 
{
    [SerializeField] private Tile _woodMinerTile;
    new protected void OnMouseDown()
    {
        // Place corresponding Miner Sort
        PlaceMinerType(_woodMinerTile);
    }
}