using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneMinerTile : MinerTile
{
    [SerializeField] private float _mineDuration;
    [SerializeField] private Item _stoneItem;

    private void Update()
    {       // Find 'Mine()' on MinerTile.cs
        Mine(_stoneItem, _mineDuration);
    }
}
