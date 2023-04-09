using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldTile : ResourceTile 
{
    [SerializeField] private Tile _goldMinerTile;
    new protected void OnMouseDown()
    {
        PlaceMinerType(_goldMinerTile);
    }
}
