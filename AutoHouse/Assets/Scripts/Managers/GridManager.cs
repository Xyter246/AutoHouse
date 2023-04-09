using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int _width, _height;
    [SerializeField] private Tile _grassTilePrefab;
    [SerializeField] private Transform _player;

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