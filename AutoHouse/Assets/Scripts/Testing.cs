using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Testing : MonoBehaviour {

    private Grid grid;

    [SerializeField] int gridWidth = 4;
    [SerializeField] int gridHeight = 2;
    [SerializeField] float cellSize = 1f;

    private void Start() {   
        grid = new Grid(gridWidth, gridHeight, cellSize);
    }

    // Checks if LMB is pressed down, if so set grid position value to 56
    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            grid.SetValue(UtilsClass.GetMouseWorldPosition(), 56);
        }

        if (Input.GetMouseButtonDown(1)){
            Debug.Log(grid.GetValue(UtilsClass.GetMouseWorldPosition()));
        }
    }
}
