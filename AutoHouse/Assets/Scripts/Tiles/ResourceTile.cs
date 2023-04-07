using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceTile : Tile {
    
    new protected void OnMouseDown()
    {   // Only execute if not over UI
        if (!Functions.IsCursorOverUIObject() && SelectedBuildingType == SelectedBuildingType.CompareTag("MinerTile")) {
            // if Miner is selected, only then place the SelectedBuildingType
            Debug.Log("Should exclusively place Miner on Resource Tiles");
            Instantiate(SelectedBuildingType, new Vector3(transform.position.x, transform.position.y, -1), Quaternion.identity);
        } else {
            Debug.Log("Not A Suitable Location! (Miners Only)");
        }
    }
}
