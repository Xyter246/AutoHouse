using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceButtonActiveState : GameManager
{
    private void Start()
    {
        if (!GameHotKeys.MODULAR_RESOURCES) { gameObject.SetActive(false); }
    }
}
