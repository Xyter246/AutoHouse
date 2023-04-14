using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceButtonActiveState : GameManager
{
    private void Start()
    {
        // When game starts, determine of Modular Resources is on or not. Currently a necessity to play
        if (!GameHotKeys.MODULAR_RESOURCES) { gameObject.SetActive(false); }
    }
}
