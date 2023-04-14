using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodTileButton : GameManager
{
    [SerializeField] private Tile _oreType;

    public void OnClick()
    {
        // If button is clicked, select the correct ore
        SelectedBuildingType = _oreType;
    }
}
