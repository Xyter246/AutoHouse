using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour 
{
    protected static Functions func = new Functions();
    protected static GridManager gridManager = new GridManager();
    protected static Tile _selectedBuildingType;

    // Static variables for resource amounts (can replace 'public' with 'protected' access modifier)
    public static int AMOUNT_COAL = 0;
    public static int AMOUNT_COPPER = 0;
    public static int AMOUNT_GOLD = 0;
    public static int AMOUNT_IRON = 0;
    public static int AMOUNT_STONE = 0;
    public static int AMOUNT_WOOD = 0;

    // A GameManager Property called SelectedBuildingType, let's the user place and interact with certain Tiles
    public static Tile SelectedBuildingType
    {
        get { return _selectedBuildingType; }
        set { _selectedBuildingType = value; }
    }
}