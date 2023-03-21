using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour 
{
    [SerializeField] int gridWidth = 4;
    [SerializeField] int gridHeight = 2;
    [SerializeField] float cellSize = 1f;

    private void Start() 
    {   
        Grid grid = new Grid(gridWidth, gridHeight, cellSize);
    }

}
