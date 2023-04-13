using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedBuildingsManager : GameManager
{
    [SerializeField] private Tile _assemblerTile;
    [SerializeField] private GameObject _assemblerButton;
    [SerializeField] private Tile _coalTile;
    [SerializeField] private GameObject _coalButton;
    [SerializeField] private Tile _copperTile;
    [SerializeField] private GameObject _copperButton;
    [SerializeField] private Tile _ironTile;
    [SerializeField] private GameObject _ironButton;
    [SerializeField] private Tile _goldTile;
    [SerializeField] private GameObject _goldButton;

    void Update()
    {
        if (SelectedBuildingType == _assemblerTile && func.IsThisGameObjectLocked(_assemblerButton) == true) { SelectedBuildingType = null; }
        if (SelectedBuildingType == _coalTile && func.IsThisGameObjectLocked(_coalButton) == true) { SelectedBuildingType = null; }
        if (SelectedBuildingType == _copperTile && func.IsThisGameObjectLocked(_copperButton) == true) { SelectedBuildingType = null; }
        if (SelectedBuildingType == _ironTile && func.IsThisGameObjectLocked(_ironButton) == true) { SelectedBuildingType = null; }
        if (SelectedBuildingType == _goldTile && func.IsThisGameObjectLocked(_goldButton) == true) { SelectedBuildingType = null; }
    }
}
