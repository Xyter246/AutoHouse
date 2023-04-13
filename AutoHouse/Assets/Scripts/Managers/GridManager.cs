using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class GridManager : GameManager
{
    [SerializeField] private int _width, _height;
    [SerializeField] private Tile _grassTilePrefab;
    [SerializeField] private GameObject _blockadeTilePrefab;
    [SerializeField] private Transform _player;

    private void Start()
    {
        // Generate the Grid for the Game
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        // Cycles through Axes
        for (int x = 0; x <= _width; x++) {
            for (int y = 0; y <= _height; y++) {
                // if GenerateGrid is at borders, place 'Blockade'...
                if ((x == 0 || x == _width) && (y != 0 || y != _height)) {
                    var blockadeTile = Instantiate(_blockadeTilePrefab, new Vector3(x, y), Quaternion.identity);
                    blockadeTile.name = $"Blockade {x} {y}";
                } else if (y == 0 || y == _height) {
                    var blockadeTile = Instantiate(_blockadeTilePrefab, new Vector3(x, y), Quaternion.identity);
                    blockadeTile.name = $"Blockade {x} {y}";
                } else {
                    // else create Grass tiles with corresponding Tile with name in hierarchy
                    var spawnedTile = Instantiate(_grassTilePrefab, new Vector3(x, y), Quaternion.identity);
                    spawnedTile.name = $"Grass Tile {x} {y}";
                    // ... and color
                    spawnedTile.Init(x, y);
                }
            }
        }
        // Set player in middle of the grid
        _player.transform.position = new Vector3((float)_width / 2 - 0.5f, (float)_height / 2 - 0.5f, -1);
    }
}
