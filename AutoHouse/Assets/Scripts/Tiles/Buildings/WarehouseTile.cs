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
        List<GameObject> boxList = func.GetObjectsInBox();
        foreach (var obj in boxList)
        {
            if (obj.CompareTag("Items")) {
                SpriteRenderer objSprite = obj.GetComponent<SpriteRenderer>();
                if (objSprite.sprite == _coal) { AMOUNT_COAL++; } else
                if (objSprite.sprite == _copper) { AMOUNT_COPPER++; } else
                if (objSprite.sprite == _gold) { AMOUNT_GOLD++; } else
                if (objSprite.sprite == _iron) { AMOUNT_IRON++; } else
                if (objSprite.sprite == _stone) { AMOUNT_STONE++; } else
                if (objSprite.sprite == _wood) { AMOUNT_WOOD++; }
                Destroy(obj);
            }
        }
    }
}
