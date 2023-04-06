using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int _width, _height;
    [SerializeField] private Tile _grassTilePrefab;
    [SerializeField] private Transform _player;
    private Dictionary<Vector2, Tile> _tiles;

    private void Start()
    {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        _tiles = new Dictionary<Vector2, Tile>();
        // Cycles through Axes
        for (int x = 0; x < _width; x++) {
            for (int y = 0; y < _height; y++) {
                // Create the corresponding Tile with name...
                var spawnedTile = Instantiate(_grassTilePrefab, new Vector3(x, y), Quaternion.identity);
                spawnedTile.name = $"Tile {x} {y}";
                // ... and color
                
                spawnedTile.Init(x, y);

                // Add tile to Dictionary
                _tiles[new Vector2(x, y)] = spawnedTile;
            }
        }

        _player.transform.position = new Vector3((float)_width / 2 - 0.5f, (float)_height / 2 - 0.5f, -1);
    }

    public Tile GetTileAtPosition(Vector2 pos)
    {
        if (_tiles.TryGetValue(pos, out var tile))
        {
            Debug.Log(tile.name);
            return tile;
        }
            return null;
    }
    public Vector2 GetMousePosition()
    {
        // Get mouse position in pixels
        Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        // Transfer pixel location to world x and y
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
        // Round x and y to nearest integer
        Vector2 mousePosition = new Vector2(Mathf.Round(worldPosition.x), Mathf.Round(worldPosition.y));
        return mousePosition;
    }
}
