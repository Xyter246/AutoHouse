using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoalTile : ResourceTile 
{
    [SerializeField] private Tile _coalMinerTile;
    new protected void OnMouseDown()
    {
        // Place corresponding Miner Sort
        PlaceMinerType(_coalMinerTile);
    }
}