using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class MinerTile : Tile
{
    protected bool Mine(Item _resourceItem, float _mineDuration, int _amountProduced, int _amountExtracted)
    {
            // Checks if there isn't an item already
        if (_amountProduced <= _amountExtracted) {
            // Checks if it's time to create an Item
            if ((Time.time % _mineDuration) <= Time.deltaTime) {
                Instantiate(_resourceItem, transform.position + Vector3.back, Quaternion.identity);

                return true;
            } else { return false; } // if it's not time, don't
        }
        else { // Miner has something still on it, so don't spawn another resource
            return false;
        }
    }

    #region "GameTick Mining (Test Area)"
    //private void Awake()
    //{
    //    GameTickSystem.OnTick += GameTickSystem_OnTick;
    //}

    //private void GameTickSystem_OnTick(object sender, GameTickSystem.OnTickEventArgs e)
    //{
    //    if (gameObject != null) { 
    //    Debug.Log("Tick: " + e.tick);
    //    if ((e.tick % _mineDurationTicks) == 0) {
    //        Instantiate(_ironItem, transform.position + Vector3.back, Quaternion.identity);
    //      }
    //    }
    //}
    #endregion
}
