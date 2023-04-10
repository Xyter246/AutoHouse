using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class GridManager : GameManager
{
    [SerializeField] private int _width, _height;
    [SerializeField] private Tile _grassTilePrefab;
    [SerializeField] private Transform _player;
    public static int TileRotation;

    private void Start()
    {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        // Cycles through Axes
        for (int x = 0; x < _width; x++) {
            for (int y = 0; y < _height; y++) {
                // Create the corresponding Tile with name in hierarchy
                var spawnedTile = Instantiate(_grassTilePrefab, new Vector3(x, y), Quaternion.identity);
                spawnedTile.name = $"Tile {x} {y}";
                // ... and color
                spawnedTile.Init(x, y);
            }
        }
        // Set player in middle of the grid
        _player.transform.position = new Vector3((float)_width / 2 - 0.5f, (float)_height / 2 - 0.5f, -1);
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
            if (Input.GetKey(KeyCode.LeftShift)) {
                // rotate the 'rotation variable'
                if (TileRotation == 0) { TileRotation = 270; } else
                if (TileRotation == 90) { TileRotation = 0; } else
                if (TileRotation == 180) { TileRotation = 90; } else
                if (TileRotation == 270) { TileRotation = 180; }
            } else {
                // rotate the 'rotation variable'
                if (TileRotation == 0) { TileRotation = 90; } else
                if (TileRotation == 90) { TileRotation = 180; } else
                if (TileRotation == 180) { TileRotation = 270; } else
                if (TileRotation == 270) { TileRotation = 0; }
            }
        }
    }

    public int RotateTile()
    {       // Same code per Rotation
        switch (TileRotation) {
            case 0:
                return TileRotation;
            case 90:
                return TileRotation;
            case 180:
                return TileRotation;
            case 270:
                return TileRotation;
            default:
                Debug.Log("DEFAULTED_ROTATION");
                return -1;
        }
    }

    #region Useless?
    //public Tile GetTileAtPosition(Vector2 pos)
    //{
    //    if (_tiles.TryGetValue(pos, out var tile))
    //    {
    //        Debug.Log(tile.name);
    //        return tile;
    //    }
    //        return null;
    //}
    #endregion
}
