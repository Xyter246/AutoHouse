using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class GameManager : MonoBehaviour 
{
    [SerializeField] protected static Tile _selectedBuildingType;
    [SerializeField] protected static Tile _ghostTileType;

    public Tile SelectedBuildingType
    {
        get {
            return _selectedBuildingType;
        }
        set {
            _selectedBuildingType = value;
        }
    }

    private void Update()
    {
        if (SelectedBuildingType != null) {
            _ghostTileType = SelectedBuildingType;
        }
    }
}