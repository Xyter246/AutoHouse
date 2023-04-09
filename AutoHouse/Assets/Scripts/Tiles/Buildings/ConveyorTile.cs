using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorTile : Tile
{
    Functions func = new Functions();

    private void Awake()
    {
        //Vector3 _directedPosition = (Vector3)transform.position;
        //// Draw a ray for debugging
        //Debug.DrawRay(transform.position, Vector3.zero, Color.green, 1000f);
        //// Draw a physics Dot and if there is a gameobject report that back
        //Collider2D[] _customColliderArray = Physics2D.OverlapPointAll(_directedPosition);
        //List<GameObject> gameObjects = new List<GameObject>();
        //foreach (Collider2D collider2D in _customColliderArray) {
        //    gameObjects.Add(collider2D.gameObject);
        //}
        //Debug.Log(gameObjects);

        Debug.Log(func.CheckMyPosition());
    }
}
