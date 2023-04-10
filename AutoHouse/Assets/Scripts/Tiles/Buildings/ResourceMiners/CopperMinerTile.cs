using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopperMinerTile : MinerTile
{
    [SerializeField] private float _mineDuration;
    [SerializeField] private Item _copperItem;

    private void Update()
    {       // Find 'Mine()' on MinerTile.cs
        Mine(_copperItem, _mineDuration);
    }
}
