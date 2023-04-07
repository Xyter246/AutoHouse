using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopperTile : ResourceTile 
{
    [SerializeField] private Tile _copperMinerTile;
    new protected void OnMouseDown()
    {
        PlaceMinerType(_copperMinerTile);
    }
}