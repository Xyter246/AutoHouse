using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorButton : GameManager 
{
    [SerializeField] private Tile _buildingType;

    public void OnClick()
    {
        SelectedBuildingType = _buildingType;
    }
}
