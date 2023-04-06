using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class GameManager : MonoBehaviour 
{
    [SerializeField] private static Tile _selectedBuildingType;

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