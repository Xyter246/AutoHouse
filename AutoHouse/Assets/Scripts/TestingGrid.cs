using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
using UnityEngine.Tilemaps;
using UnityEditor.U2D.Path;
using Unity.VisualScripting;

public class TestingGrid : MonoBehaviour{

    private Grid<int> grid;

    [SerializeField] int gridWidth = 423;
    [SerializeField] int gridHeight = 307;
    [SerializeField] float cellSize = 1f;
    public int debugValue = 10;
    public static Tilemap TileMap;

    private void Start() {
      //grid = new Grid<int>(gridWidth, gridHeight, cellSize, originPosition)
        grid = new Grid<int>(gridWidth, gridHeight, cellSize, new Vector3(-199, -151));
        CheckWholeGrid();
    }

    private void Update() {
        // Checks if LMB is pressed down, if so set grid position value to a new value
        if (Input.GetMouseButtonDown(0)) {
            grid.SetValue(UtilsClass.GetMouseWorldPosition(), debugValue);
        }
        // checks if RMB is pressed down, if so display the value in console
        if (Input.GetMouseButtonDown(1)){
            Debug.Log(grid.GetValue(UtilsClass.GetMouseWorldPosition()));
        }
    }

    private void CheckWholeGrid()
    {
        for (int x = 0; x < grid.gridArray.GetLength(0); x++) {
            for (int y = 0; y < grid.gridArray.GetLength(1); y++) {
                if(BuildableGridPosition(x, y))
                {
                    grid.gridArray[x, y] = 1;
                    grid.debugTextArray[x, y].text = grid.gridArray[x, y].ToString();
                }
            }
        }
    }

    private bool BuildableGridPosition(int x, int y)
    {
        Vector3Int position = Vector3Int.FloorToInt(grid.GetWorldPosition(x, y));
        if (TestingGrid.TileMap.GetSprite(position) == null)
        {
            return false;
        }
        return true;
    }
}
