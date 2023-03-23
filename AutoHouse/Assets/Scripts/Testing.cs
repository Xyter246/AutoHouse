using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Testing : MonoBehaviour {

    private Grid<int> grid;

    [SerializeField] int gridWidth = 4;
    [SerializeField] int gridHeight = 2;
    [SerializeField] float cellSize = 2f;
    public int placeObject = 1;

    private void Start() {
      //grid = new Grid<int>(gridWidth, gridHeight, cellSize, originPosition,    gridObject)
        grid = new Grid<int>(gridWidth, gridHeight, cellSize, new Vector3(5, 0));
    }

    private void Update() {
        // Checks if LMB is pressed down, if so set grid position value to a new value
        if (Input.GetMouseButtonDown(0)) {
            grid.SetValue(UtilsClass.GetMouseWorldPosition(), placeObject);
        }
        // checks if RMB is pressed down, if so display the value in console
        if (Input.GetMouseButtonDown(1)){
            Debug.Log(grid.GetValue(UtilsClass.GetMouseWorldPosition()));
        }
    }
}
