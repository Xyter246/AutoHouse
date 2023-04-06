using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronTileButton : GameManager
{
    [SerializeField] private Tile _oreType;

    public void OnClick()
    {
        Debug.Log("Button Pressed!");
        SelectedBuildingType = _oreType;
    }
}
