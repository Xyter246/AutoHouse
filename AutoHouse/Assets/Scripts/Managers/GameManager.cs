using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour 
{
    protected static Functions func = new Functions();
    protected static GridManager gridManager = new GridManager();
    protected static Tile _selectedBuildingType;

    public Tile SelectedBuildingType
    {
        get {
            return _selectedBuildingType;
        }
        set {
            _selectedBuildingType = value;
        }
    }
}