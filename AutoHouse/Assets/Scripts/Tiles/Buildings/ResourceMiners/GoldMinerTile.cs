using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldMinerTile : MinerTile
{
    [SerializeField] private float _mineDuration;
    [SerializeField] private Item _goldItem;

    private void Update()
    {       // Find 'Mine()' on MinerTile.cs
        Mine(_goldItem, _mineDuration);
    }
}
