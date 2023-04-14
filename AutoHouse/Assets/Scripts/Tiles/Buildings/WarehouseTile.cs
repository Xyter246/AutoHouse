using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WarehouseTile : Tile
{
    [SerializeField] Sprite _coal;
    [SerializeField] Sprite _copper;
    [SerializeField] Sprite _gold;
    [SerializeField] Sprite _iron;
    [SerializeField] Sprite _stone;
    [SerializeField] Sprite _wood;

    private void Update()
    {
        // Check if something of importance hit the Warehouse edges
        List<GameObject> boxList = func.GetObjectsInBox(gameObject);
        foreach (var obj in boxList)
        {
            // If they are classified as Items...
            if (obj.CompareTag("Items")) {
                SpriteRenderer objSprite = obj.GetComponent<SpriteRenderer>();
                // ...Add them to the corresponding total in inventory
                if (objSprite.sprite == _wood) { AMOUNT_WOOD++; } else
                if (objSprite.sprite == _stone) { AMOUNT_STONE++; } else
                if (objSprite.sprite == _coal) { AMOUNT_COAL++; } else
                if (objSprite.sprite == _copper) { AMOUNT_COPPER++; } else
                if (objSprite.sprite == _iron) { AMOUNT_IRON++; } else
                if (objSprite.sprite == _gold) { AMOUNT_GOLD++; } 
                // Destroy that Item so it won't be counted twice... Or more.
                Destroy(obj);
            }
        }
    }
}
