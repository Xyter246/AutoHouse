using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoalMinerTile : MinerTile
{
    [SerializeField] private float _mineDuration;
    [SerializeField] private Item _coalItem;


    private void Update()
    {       // Find 'Mine()' on MinerTile.cs
        Mine(_coalItem, _mineDuration);
    }
}
