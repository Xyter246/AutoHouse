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
        if (SelectedBuildingType == _assemblerTile && IsThisGameObjectLocked(_assemblerButton)) { SelectedBuildingType = null; }
        if (SelectedBuildingType == _coalTile && IsThisGameObjectLocked(_coalButton)) { SelectedBuildingType = null; }
        if (SelectedBuildingType == _copperTile && IsThisGameObjectLocked(_copperButton)) { SelectedBuildingType = null; }
        if (SelectedBuildingType == _ironTile && IsThisGameObjectLocked(_ironButton)) { SelectedBuildingType = null; }
        if (SelectedBuildingType == _goldTile && IsThisGameObjectLocked(_goldButton)) { SelectedBuildingType = null; }
    }

    private bool IsThisGameObjectLocked(GameObject gameobject)
    {
        // if the gameobject has Locked (as a Child), then the gameObject must be Locked and should not be available
        if (gameobject.transform.Find("Locked").gameObject != null) { return true; }
        // if it isn't locked, return false
        else return false;
    }
}
