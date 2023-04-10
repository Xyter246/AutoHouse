using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronMinerTile : MinerTile
{
    [SerializeField] private float _mineDuration;
    [SerializeField] private Item _ironItem;

    private void Update()
    {       // Find 'Mine(parameters)' on MinerTile.cs
        Mine(_ironItem, _mineDuration);
    }

}