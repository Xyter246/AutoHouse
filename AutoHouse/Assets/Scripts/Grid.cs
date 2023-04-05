using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
using UnityEngine.Tilemaps;
using System;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;

public class Grid<TGridObject> {
    private int width;
    private int height;
    private float cellSize;
    private Vector3 originPosition;
    public TGridObject[,] gridArray;
    public TextMesh[,] debugTextArray;


    public Grid(int width, int height, float cellSize, Vector3 originPosition)
    {
        this.width = width;
        this.height = height;
        this.cellSize = cellSize;
        this.originPosition = originPosition;
        int fontSize = 6;

        gridArray = new TGridObject[width, height];

        bool showDebug = true;
        if (showDebug) {
            // Create the Debug Grid
            debugTextArray = new TextMesh[width, height];
            drawGrid(cellSize, fontSize);
        }
    }

    private void drawGrid(float cellSize, int fontSize) {
        for (int x = 0; x < gridArray.GetLength(0); x++) {
            for (int y = 0; y < gridArray.GetLength(1); y++) {
                // Debug number placement
                debugTextArray[x, y] = UtilsClass.CreateWorldText(gridArray[x, y].ToString(), null, GetWorldPosition(x, y) + new Vector3(cellSize, cellSize) * 0.5f, fontSize, Color.white, TextAnchor.MiddleCenter);

                // Debug lines left and bottom
                Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x, y + 1), Color.white);
                Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x + 1, y), Color.white);
                // Create the top and right-most lines of the Grid
                Debug.DrawLine(GetWorldPosition(0, height), GetWorldPosition(width, height), Color.white);
                Debug.DrawLine(GetWorldPosition(width, 0), GetWorldPosition(width, height), Color.white);
            }
        }
    }
    
    // Create vector for Grid numbers
    public Vector3 GetWorldPosition(int x, int y)
    {
        return new Vector3(x, y) * cellSize + originPosition;
    }

    private void GetXY(Vector3 worldPosition, out int x, out int y)
    {
        x = Mathf.FloorToInt((worldPosition - originPosition).x / cellSize);
        y = Mathf.FloorToInt((worldPosition - originPosition).y / cellSize);
    }

    // Set a Value of a grid position using C#
    public void SetValue(int x, int y, TGridObject value)
    {
        if (x >= 0 && y >= 0 && x < width && y < height)
        {
            gridArray[x, y] = value;
            debugTextArray[x, y].text = gridArray[x, y].ToString();
        }
    }

    // Set a value of a grid position using Mouse CLick
    public void SetValue(Vector3 worldPosition, TGridObject value)
    {
        int x, y;
        GetXY(worldPosition, out x, out y);
        SetValue(x, y, value);
    }

    // Get a value of a grid position using C#
    public TGridObject GetValue(int x, int y)
    {
        if (x >= 0 && y >= 0 && x < width && y < height) {
            return gridArray[x, y];
        }
        else {
            return default(TGridObject);
        }
    }
    public TGridObject GetValue(Vector3 worldPosition)
    {
        int x, y;
        GetXY(worldPosition, out x, out y);
        return GetValue(x, y);
    }
}