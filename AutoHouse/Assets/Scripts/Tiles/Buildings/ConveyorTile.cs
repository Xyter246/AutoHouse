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
        CheckAndMoveItems(_conveyorDir, _conveyorSpeed);
    }

    private void CheckAndMoveItems(Vector2 _conveyorDir, float _conveyorSpeed)
    {
        // Create Vectors
        _conveyorDir = _conveyorDir.normalized;
        Vector2 _conveyorBoxOrigin = -0.25f * _conveyorDir;
        Vector2 _conveyorBoxSize = 1.5f * _conveyorDir;

        // Extra width for the 'box'
        switch (_conveyorBoxSize.x) {
            case 0: // If _conveyorBoxSize is in the Y direction, make X wider
                _conveyorBoxSize.x += _conveyorWidth;
                _conveyorBoxSize.y = Math.Abs(_conveyorBoxSize.y);
                break;
            default: // If _conveyorBoxSize is in the X direction, make Y wider
                _conveyorBoxSize.y += _conveyorWidth;
                _conveyorBoxSize.x = Math.Abs(_conveyorBoxSize.x);
                break;
        }

        // for every object found in an arbitrary box (rectangle more or less)...
        foreach (var obj in func.GetObjectsInBox(null, (Vector2)transform.position + _conveyorBoxOrigin, _conveyorBoxSize)) {
            GameObject go = obj.gameObject;
            // Check if they are an Item
            if (go.CompareTag("Items")) {
                // If so, move them slightly
                go.transform.position = Time.deltaTime * _conveyorSpeed * (Vector3)_conveyorDir + go.transform.position;
            }
        }
    }
}