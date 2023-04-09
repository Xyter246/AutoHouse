using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldMinerTile : MinerTile
{
    [SerializeField] private float _mineDuration;
    [SerializeField] private Item _goldItem;
    private int _amountExtracted = 0;
    private int _amountProduced = 0;

    private void Update()
    {       // Find 'Mine()' on MinerTile.cs
        if (Mine(_goldItem, _mineDuration, _amountProduced, _amountExtracted)) {
            _amountProduced++;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _amountExtracted++;
    }
}
