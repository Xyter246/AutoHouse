using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceTile : Tile {
    
    public override void OnMouseDown()
    {   // Only execute if not over UI
        if (!Functions.IsCursorOverUIObject()) {
            if (SelectedBuildingType.CompareTag("Resources")) {
                Debug.Log("The tag for this GameObject is" + gameObject.tag);
                Instantiate(SelectedBuildingType, transform.position, Quaternion.identity);
            } else {
                Debug.Log("Can't Find Tag!");
            }          
        }
    }

    new private void OnMouseOver()
    {   // Only execute if not over UI
        if (!Functions.IsCursorOverUIObject()) {
            // On RMB, then destroy object and replace with replaceobject (standard is grass)
            if (Input.GetKey(KeyCode.Mouse1)) {
                Destroy(gameObject);
            }
        }
    }
}
