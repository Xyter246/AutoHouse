using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinerButton : GameManager
{
    [SerializeField] private Tile _buildingType;

    public void OnClick()
    {
        // If button is clicked, select the correct building
        SelectedBuildingType = _buildingType;
    }
}
