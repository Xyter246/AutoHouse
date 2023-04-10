using System;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ConveyorTile : Tile
{
    [SerializeField] private Tile _conveyor;
    [SerializeField] private float _conveyorSpeed;
    private Vector2Int gridPosition;
    private Vector2 _checkDirection;
    private Vector3 _parseDirection;    

    private void Awake()
    {
        // Log every object on the position of the Belt
        gridPosition = func.GetRoundedGridPosition(gameObject);
        // Check which rotation is currently selected
        switch (GridManager.TileRotation) {
            case 0: // If North, then...
                _checkDirection = Vector2.down;
                _parseDirection = Vector3.up;
                transform.Rotate(0, 0, 0, Space.World);
                break;
            case 90: // If East, then...
                _checkDirection = Vector2.left;
                _parseDirection = Vector3.right;
                transform.Rotate(0, 0, -90, Space.World);
                break;
            case 180: // If South, then...
                _checkDirection = Vector2.up;
                _parseDirection = Vector3.down;
                transform.Rotate(0, 0, 180, Space.World);
                break;
            case 270: // If West, then...
                _checkDirection = Vector2.right;
                _parseDirection = Vector3.left;
                transform.Rotate(0, 0, 90, Space.World);
                break;
            default: // If TileRotation has invalid value, then nothing
                break;
        }
    }
    
    private void Update()
    {   
        // Move every item on the conveyor in the correct direction
        foreach (var obj in func.GetObjectsOnMyPosition(gameObject)) {
            GameObject go = obj.gameObject;
            if (go.CompareTag("Items")) {
                go.transform.position = Time.deltaTime * _conveyorSpeed * _parseDirection + go.transform.position;
            }
        }

        //Check behind the Conveyor if there is an Item on a Miner
        CheckAndMoveItems(gameObject, _checkDirection, _parseDirection, _conveyorSpeed);
        // And also in between, Items have a smaller hitbox so need to check more
        CheckAndMoveItems(gameObject, 0.5f * _checkDirection, _parseDirection, _conveyorSpeed, Color.green);


        //#region "Check and pass items behind conveyor"
        //foreach (var obj in func.GetRelativePosition(gameObject, _checkDirection)) {
        //    GameObject go = obj.gameObject;
        //    if (go.CompareTag("Items")) {
        //        go.transform.position = Time.deltaTime * _conveyorSpeed * _parseDirection + go.transform.position;
        //    } else {
        //        // Check behind the Conveyor at half distance to still move the item
        //        foreach (var obj2 in func.GetRelativePosition(gameObject, 0.5f * _checkDirection)) {
        //            GameObject go2 = obj2.gameObject;
        //            if (go2.CompareTag("Items")) {
        //                go2.transform.position = Time.deltaTime * _conveyorSpeed * _parseDirection + go2.transform.position;
        //            }
        //        }
        //    }
        //}
        //#endregion
    }

    private void CheckAndMoveItems(GameObject gameObject, Vector2 _checkDirection, Vector3 _parseDirection, float _conveyorSpeed, Color? _color = null)
    {
        if (_color == null) { _color = Color.red; }
        foreach (var obj in func.GetRelativePosition(gameObject, _checkDirection, _color)) {
            GameObject go = obj.gameObject;
            if (go.CompareTag("Items")) {
                go.transform.position = Time.deltaTime * _conveyorSpeed * _parseDirection + go.transform.position;
            }
        }
    }
}