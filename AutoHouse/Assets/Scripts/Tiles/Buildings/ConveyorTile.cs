using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ConveyorTile : Tile
{
    [SerializeField] private Tile _conveyor;
    [SerializeField] private float _conveyorSpeed;
    private Vector2 _conveyorBack; // The position relative to the origin of the conveyor where it should start pulling items towards it
    private Vector2 _conveyorDir; // The length and direction of the conveyor

    private void Awake()
    {
        // Check which rotation is currently selected
        switch (GameHotKeys.TileRotation) {
            case 0: // If North, then...
                _conveyorBack = Vector2.down;
                _conveyorDir = 1.5f * Vector2.up;
                transform.Rotate(0, 0, 0, Space.World);
                break;
            case 90: // If East, then...
                _conveyorBack = Vector2.left;
                _conveyorDir = 1.5f * Vector2.right;
                transform.Rotate(0, 0, 270, Space.World);
                break;
            case 180: // If South, then...
                _conveyorBack = Vector2.up;
                _conveyorDir = 1.5f * Vector2.down;
                transform.Rotate(0, 0, 180, Space.World);
                break;
            case 270: // If West, then...
                _conveyorBack = Vector2.right;
                _conveyorDir = 1.5f * Vector2.left;
                transform.Rotate(0, 0, 90, Space.World);
                break;
            default: // If TileRotation has invalid value, then nothing
                break;
        }
    }

    private void Update()
    {
        // Every frame, check on the back, main, and front part of every conveyorTile and move items if necessary
        CheckAndMoveItems(_conveyorBack, _conveyorDir, _conveyorSpeed);
    }

    private void CheckAndMoveItems(Vector2 _conveyorBack, Vector2 _conveyorDir, float _conveyorSpeed)
    {
        Vector2 _conveyorWidth;
        // Extra width for the 'box'
        switch (_conveyorDir.x) {
            case 0:
                _conveyorWidth = new Vector2(0.1f, 0);
                break;
            default:
                _conveyorWidth = new Vector2(0, 0.1f);
                break;
        }

        // for every object found in an arbitrary box (rectangle more or less)...
        foreach (var obj in func.GetObjectsInBox((Vector2)transform.position + 0.5f * (_conveyorDir + _conveyorBack), _conveyorDir + _conveyorWidth)) {
            GameObject go = obj.gameObject;
            // Check if they are an Item
            if (go.CompareTag("Items")) {
                // If so, move them up slightly (constantly)
                go.transform.position = Time.deltaTime * _conveyorSpeed * (Vector3)_conveyorDir.normalized + go.transform.position;
            }
        }
    }
}