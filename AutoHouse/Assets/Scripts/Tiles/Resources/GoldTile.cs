using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldTile : ResourceTile 
{
    [SerializeField] private Tile _goldMinerTile;
    new protected void OnMouseDown()
    {
        // Place corresponding Miner Sort
        PlaceMinerType(_goldMinerTile);
    }
}
