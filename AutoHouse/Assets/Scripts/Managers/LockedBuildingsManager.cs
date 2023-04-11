using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class LockedBuildingsManager : GameManager
{
    [SerializeField] private Tile _assembler;
    [SerializeField] private GameObject _assemblerButton;

    void Update()
    {
        if (SelectedBuildingType == _assembler && func.IsThisGameObjectLocked(_assemblerButton) == true) { SelectedBuildingType = null; }
    }
}
