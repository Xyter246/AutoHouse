using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopperTileButton : GameManager
{
    [SerializeField] private Tile _oreType;

    public void OnClick()
    {
        SelectedBuildingType = _oreType;
    }
}
