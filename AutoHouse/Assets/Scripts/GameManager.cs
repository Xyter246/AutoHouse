using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Tile _selectedBuildingType;

    public Tile SelectedBuildingType
    {
        get
        {
            return _selectedBuildingType;
        }
        protected set
        {
            _selectedBuildingType = value;
        }
    }

    private void Update()
    {
        Debug.Log("Tile is: " + SelectedBuildingType);
    }
}
