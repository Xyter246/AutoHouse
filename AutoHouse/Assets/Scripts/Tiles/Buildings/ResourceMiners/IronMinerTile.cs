using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronMinerTile : Tile
{
    private int mineTick;
    [SerializeField] private int mineTickDuration;

    private void Awake()
    {
        GameTickSystem.OnTick += GameTickSystem_OnTick;
    }

    private void GameTickSystem_OnTick(object sender, GameTickSystem.OnTickEventArgs e)
    {

        if ((mineTick % 20) == 0) {
            
        }
    }

}
