using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ConveyorTile : Tile
{
    [SerializeField] private Tile _conveyor;
    [SerializeField] private float _conveyorSpeed;
    [SerializeField] private float _conveyorWidth; // Width from middle of conveyor where Items are still transported
    private Vector2 _conveyorDir; // The length and direction of the conveyor

    private void Awake()
    {
        // Check which rotation is currently selected
        switch (GameHotKeys.TileRotation) {
            case 0: // If North, then...
                _conveyorDir = Vector2.up;
                transform.Rotate(0, 0, 0, Space.World);
                break;
            case 90: // If East, then...
                _conveyorDir = Vector2.right;
                transform.Rotate(0, 0, 270, Space.World);
                break;
            case 180: // If South, then...
                _conveyorDir = Vector2.down;
                transform.Rotate(0, 0, 180, Space.World);
                break;
            case 270: // If West, then...
                _conveyorDir = Vector2.left;
                transform.Rotate(0, 0, 90, Space.World);
                break;
            default: // If TileRotation has invalid value, then nothing
                break;
        }
    }

    private void Update()
    {
        // Every frame, check on the back, main, and front part of every conveyorTile and move items if necessary
        if (GRAEFF_MODE) { // ..in GRAEFFMODE
            CheckAndMoveItemsGraeffMode(_conveyorDir, _conveyorSpeed);
        } else { // ..or normally
            CheckAndMoveItems(_conveyorDir, _conveyorSpeed);
            CheckForMiner(_conveyorDir, _conveyorSpeed);
        }
    }

    private void MoveItemsInList(List<GameObject> gameObjects, Vector2 _conveyorDir, float? _conveyorSpeed = null)
    {
        if (_conveyorSpeed == null) { _conveyorSpeed = 0.5f; }
        foreach (var obj in gameObjects) {
            GameObject go = obj.gameObject;
            // Check if there are any Items
            if (go.CompareTag("Items")) {
                // If so, move them slightly
                go.transform.position += Time.deltaTime * (float)_conveyorSpeed * (Vector3)_conveyorDir;
            }
        }
    }

    private void CheckAndMoveItemsGraeffMode(Vector2 _conveyorDir, float _conveyorSpeed)
    {
        // Create Vectors, _conveyorDir must be orthogonal
        _conveyorDir = _conveyorDir.normalized;
        Vector2 _conveyorBoxOrigin = -0.25f * _conveyorDir;
        // Create Box Size using the Absolute math function. Otherwise it could be negative size and not work at all
        Vector2 _conveyorBoxSize = new(Math.Abs(1.5f * _conveyorDir.x), Math.Abs(1.5f * _conveyorDir.y));

        CreateConveyorWidth(_conveyorBoxSize);

        // for every object found in an arbitrary box (rectangle more or less)...
        List<GameObject> gameObjects = func.GetObjectsInBox(null, (Vector2)transform.position + _conveyorBoxOrigin, _conveyorBoxSize);
        // Move them
        MoveItemsInList(gameObjects, _conveyorDir, _conveyorSpeed);
    }

    private Vector2 CreateConveyorWidth(Vector2 _conveyorBoxSize)
    {
        // Extra width for the 'box'
        switch (_conveyorBoxSize.x) {
            case 0: // If _conveyorBoxSize is in the Y direction, make X wider
                _conveyorBoxSize.x += _conveyorWidth;
                _conveyorBoxSize.y = Math.Abs(_conveyorBoxSize.y);
                return _conveyorBoxSize;
            default: // If _conveyorBoxSize is in the X direction, make Y wider
                _conveyorBoxSize.y += _conveyorWidth;
                _conveyorBoxSize.x = Math.Abs(_conveyorBoxSize.x);
                return _conveyorBoxSize;
        }
    }

    private void CheckAndMoveItems(Vector2 _conveyorDir, float _conveyorSpeed)
    {
        // Create Vectors, _conveyorDir must be (very recommended) orthogonal
        _conveyorDir = _conveyorDir.normalized;
        Vector2 _conveyorBoxOrigin = 0 * _conveyorDir;
        Vector2 _conveyorBoxSize = _conveyorDir;

        _conveyorBoxSize = CreateConveyorWidth(_conveyorBoxSize);

        // for every object found in an arbitrary box...
        List<GameObject> gameObjects = func.GetObjectsInBox(null, (Vector2)transform.position + _conveyorBoxOrigin, _conveyorBoxSize);
        // Move them
        MoveItemsInList(gameObjects, _conveyorDir, _conveyorSpeed);
    }

    private void CheckForMiner(Vector2 _conveyorDir, float _conveyorSpeed)
    {
        // Create Vectors, _conveyorDir must be (very recommended) orthogonal
        _conveyorDir = _conveyorDir.normalized;

        List<GameObject> gameObjects = func.GetRelativePosition(gameObject, -0.9f * _conveyorDir);

        // for every object found in a dot
        foreach (var obj in gameObjects) {
            GameObject go = obj.gameObject;
            // If there is a minertile
            if (go.CompareTag("MinerTile")) {
                MoveItemsInList(gameObjects, _conveyorDir, _conveyorSpeed);
            }
        }
    }
}