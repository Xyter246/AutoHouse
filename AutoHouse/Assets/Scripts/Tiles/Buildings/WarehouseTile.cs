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
        if (gameObject.CompareTag("Items")) {
            Debug.Log("item that collided is of tag ITEMS");

            //switch (collision) {
            //    case collision.gameObject = _coal;
            //        break;

            //    default:
            //        Debug.Log("Not an Item");
            //        return;
            //}
        }
    }
}
