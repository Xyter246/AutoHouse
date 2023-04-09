using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : GameManager
{
    protected void OnMouseOver()
    {   // Only execute if not over UI
        if (!Functions.IsCursorOverUIObject()) {
            // On RMB, then destroy object and replace with replaceobject (standard is grass)
            if (Input.GetKey(KeyCode.Mouse1)) {
                // Destroy selected gameObject (Item)
                Destroy(gameObject);
            }
        }
    }
}
