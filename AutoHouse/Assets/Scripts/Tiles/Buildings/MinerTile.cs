using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class MinerTile : Tile
{
    protected bool Mine(Item _resourceItem, float _mineDuration)
    {
            // Checks if there isn't an item already
        if (func.GetObjectsOnMyDotPosition(gameObject).Count == 1) {
            // Checks if it's time to create an Item
            if ((Time.time % _mineDuration) <= Time.deltaTime) {
                Instantiate(_resourceItem, transform.position + Vector3.back, Quaternion.identity);

                return true;
            } else { return false; } // if it's not time, don't
        } // Miner has something still on it, so don't spawn another resource
        else { return false; }
    }
}
