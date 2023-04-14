using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

////////////////////////////////////////////////////////////////////////
///                                                                  ///
/// This Script is currently Unused, but kept for future endeavours. ///
///                                                                  ///
////////////////////////////////////////////////////////////////////////

public class GameTickSystem : MonoBehaviour
{
    private void Awake()
    {
        tick = 0;
    }

    public void Start()
    {
        GameTickSystem.OnTick += delegate (object sender, GameTickSystem.OnTickEventArgs e)
        { };
    }

    public class OnTickEventArgs : EventArgs
    {
        public int tick;
    }

    public static event EventHandler<OnTickEventArgs> OnTick;

    // 1/TICK_TIMER_MAX is GameTicks/second
    private const float TICK_TIMER_MAX = 0.2f;

    private int tick;
    private float tickTimer;

    private void Update()
    {
        tickTimer += Time.deltaTime;
        if (tickTimer >= TICK_TIMER_MAX) {
            tickTimer -= TICK_TIMER_MAX;
            tick++;
            if (OnTick != null) OnTick(this, new OnTickEventArgs { tick = tick });
        }
    }
}
