using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
using UnityEngine.UIElements.Experimental;

public class ConveyorTile : Tile
{
    [SerializeField] private Tile _conveyor;
    private int _rotation;

    private void Awake()
    {
        // Log every object on the position of the Belt
        foreach (var obj in func.GetObjectsOnMyPosition(gameObject)) { Debug.Log(obj); }
    }

    private void Update()
    {
        if (SelectedBuildingType == _conveyor) {
            if (Input.GetKeyDown(KeyCode.R)) {
                Vector2 mousePos = func.GetMousePosition();
                // rotation the conveyor
                if (_rotation == 0) { _rotation = 90; UtilsClass.CreateWorldTextPopup("facing East", mousePos); } else
                if (_rotation == 90) { _rotation = 180; UtilsClass.CreateWorldTextPopup("facing South", mousePos); } else
                if (_rotation == 180) { _rotation = 270; UtilsClass.CreateWorldTextPopup("facing West", mousePos); } else
                if (_rotation == 270) { _rotation = 0; UtilsClass.CreateWorldTextPopup("facing North", mousePos); }
            }
        }
    }

    public void CreateConveyor()
    {       // Same code per Rotation
        switch (_rotation) {
            case 0: 
                break;
            case 90:
                break;
            case 180:
                break;
            case 270: 
                break;
            default: Debug.Log("Defaulted Rotation");
                break;
        }
    }
}
