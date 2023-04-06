using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssemblerButton : GameManager
{
    [SerializeField] private Tile _buildingType;

    public void OnClick()
    {
        Debug.Log("Button Pressed!");
        SelectedBuildingType = _buildingType;
    }
}