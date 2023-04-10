using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarehouseTile : Tile
{
    [SerializeField] Item _coal;
    [SerializeField] Item _copper;
    [SerializeField] Item _gold;
    [SerializeField] Item _iron;
    [SerializeField] Item _stone;
    [SerializeField] Item _wood;

    private void Update()
    {
        List<GameObject> boxList = func.GetObjectsInBox(gameObject);
        foreach (var obj in boxList)
        {
            Debug.Log(obj);
            if (obj.CompareTag("Items")) {
                if (obj == _coal) { AMOUNT_COAL++; } else
                if (obj == _copper) { AMOUNT_COPPER++; } else
                if (obj == _gold) { AMOUNT_GOLD++; } else
                if (obj == _iron) { AMOUNT_IRON++; } else
                if (obj == _stone) { AMOUNT_STONE++; } else
                if (obj == _wood) { AMOUNT_WOOD++; }
                Destroy(obj);
            }
        }
    }
}
