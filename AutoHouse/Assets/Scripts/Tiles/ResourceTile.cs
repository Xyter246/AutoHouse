using CodeMonkey.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceTile : Tile 
{
    protected void PlaceMinerType(Tile x)
    {   // Only execute if not over UI
        if (!func.IsCursorOverUIObject() && SelectedBuildingType == SelectedBuildingType.CompareTag("MinerTile")) {
            // if Miner is selected (and not over UI), only then place the corresponding Miner
            Destroy(gameObject);
            Instantiate(x, transform.position, Quaternion.identity);
        } else {
            // If resource Tile clicked but Miner not selected, display error message at mouse cursor
            UtilsClass.CreateWorldTextPopup("Not A Suitable Location! (Miners Only)", func.GetRoundedMousePosition()); ;
        }
    }
}
