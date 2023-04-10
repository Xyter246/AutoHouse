using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ConveyorTile : Tile
{
    [SerializeField] private Tile _conveyor;
    [SerializeField] private float _conveyorSpeed;
    private Vector2Int gridPosition;
    private Vector2 _checkDirection;
    private Vector2 _parseDirection;
    private Vector2 _rightDirection;
    private Vector2 _leftDirection;

    private void Awake()
    {
        // Log every object on the position of the Belt
        gridPosition = func.GetRoundedGridPosition(gameObject);
        // Check which rotation is currently selected
        switch (GridManager.TileRotation) {
            case 0: // If North, then...
                _checkDirection = Vector2.down;
                _parseDirection = Vector2.up;
                _rightDirection = Vector2.right;
                _leftDirection = Vector2.left;
                transform.Rotate(0, 0, 0, Space.World);
                break;
            case 90: // If East, then...
                _checkDirection = Vector2.left;
                _parseDirection = Vector2.right;
                _rightDirection = Vector2.down;
                _leftDirection = Vector2.up;
                transform.Rotate(0, 0, 270, Space.World);
                break;
            case 180: // If South, then...
                _checkDirection = Vector2.up;
                _parseDirection = Vector2.down;
                _rightDirection = Vector2.left;
                _leftDirection = Vector2.right;
                transform.Rotate(0, 0, 180, Space.World);
                break;
            case 270: // If West, then...
                _checkDirection = Vector2.right;
                _parseDirection = Vector2.left;
                _rightDirection = Vector2.up;
                _leftDirection = Vector2.down;
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
                go.transform.position = Time.deltaTime * _conveyorSpeed * (Vector3)_parseDirection + go.transform.position;
            }
        }

        // Don't like this way but:
        // Every frame, check on the back, main, and front part of every conveyorTile and move items if necessary
        CheckAndMoveItems(gameObject, _checkDirection, _parseDirection, _conveyorSpeed);
        CheckAndMoveItems(gameObject, 0.5f * _parseDirection, _parseDirection, _conveyorSpeed, Color.blue);
        CheckAndMoveItems(gameObject, 0.5f * _checkDirection, _parseDirection, _conveyorSpeed, Color.green);
    }

    private void CheckAndMoveItems(GameObject gameObject, Vector2 _checkDirection, Vector3 _parseDirection, float _conveyorSpeed, Color? _color = null)
    {
        // if overload not filled, make own overload
        if (_color == null) { _color = Color.red; }
        // Method: for every object found at a position...
        foreach (var obj in func.GetRelativePosition(gameObject, _checkDirection, _color)) {
            GameObject go = obj.gameObject;
            // Check if they are an Item
            if (go.CompareTag("Items")) {
                // If so, move them up slightly (constantly)
                go.transform.position = Time.deltaTime * _conveyorSpeed * _parseDirection + go.transform.position;
            }
        }
    }
}