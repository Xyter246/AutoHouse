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
    public int testInt = 10;
    public static Tilemap TileMap;


    private void Start() {
      //grid = new Grid<int>(gridWidth, gridHeight, cellSize, originPosition)
        grid = new Grid<int>(gridWidth, gridHeight, cellSize, new Vector3(-199, -151));
    }

    private void Update() {
        // Checks if LMB is pressed down, if so set grid position value to a new value
        if (Input.GetMouseButtonDown(0)) {
            grid.SetValue(UtilsClass.GetMouseWorldPosition(), testInt);
        }
        // checks if RMB is pressed down, if so display the value in console
        if (Input.GetMouseButtonDown(1)){
            Debug.Log(grid.GetValue(UtilsClass.GetMouseWorldPosition()));
        }
    }

}
