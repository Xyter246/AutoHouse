using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour 
{
    protected static Functions func = new Functions();
    protected static GridManager gridManager = new GridManager();
    protected static Tile _selectedBuildingType;

    protected static int AMOUNT_COAL;
    protected static int AMOUNT_COPPER;
    protected static int AMOUNT_GOLD;
    protected static int AMOUNT_IRON;
    protected static int AMOUNT_STONE;
    protected static int AMOUNT_WOOD;

    public Tile SelectedBuildingType
    {
        get {
            return _selectedBuildingType;
        }
        set {
            _selectedBuildingType = value;
        }
    }
}