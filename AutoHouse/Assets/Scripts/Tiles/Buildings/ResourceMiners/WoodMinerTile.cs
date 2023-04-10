using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodMinerTile : MinerTile
{
    [SerializeField] private float _mineDuration;
    [SerializeField] private Item _woodItem;

    private void Update()
    {       // Find 'Mine()' on MinerTile.cs
        Mine(_woodItem, _mineDuration);
    }
}
