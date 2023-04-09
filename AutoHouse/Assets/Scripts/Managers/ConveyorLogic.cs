using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ConveyorLogic : BuildingTile
{
    private bool conveyorFull;

    protected void CheckNorth()
    {       // Make a new vector in the corresponding direction
        Vector2 _direction = Vector2.up;
        Vector2 _directedPosition = (Vector2)transform.position + _direction;
            // Draw a ray for debugging
        Debug.DrawRay(transform.position, _direction, Color.red, 1000f);
            // Draw a physics Dot and if there is a gameobject report that back
        Collider2D _northCollider = Physics2D.OverlapPoint(_directedPosition);
        Debug.Log("North: " + _northCollider.gameObject);
    }

    protected void CheckEast()
    {       // Make a new vector in the corresponding direction
        Vector2 _direction = Vector2.right;
        Vector2 _directedPosition = (Vector2)transform.position + _direction;
            // Draw a ray for debugging
        Debug.DrawRay(transform.position, _direction, Color.cyan, 1000f);
            // Draw a physics Dot and if there is a gameobject report that back
        Collider2D _eastCollider = Physics2D.OverlapPoint(_directedPosition);
        Debug.Log("East: " + _eastCollider.gameObject);
    }

    protected void CheckSouth()
    {       // Make a new vector in the corresponding direction
        Vector2 _direction = Vector2.down;
        Vector2 _directedPosition = (Vector2)transform.position + _direction;
            // Draw a ray for debugging
        Debug.DrawRay(transform.position, _direction, Color.white, 1000f);
            // Draw a physics Dot and if there is a gameobject report that back
        Collider2D _southCollider = Physics2D.OverlapPoint(_directedPosition);
        Debug.Log("South: " + _southCollider.gameObject);
    }

    protected void CheckWest()
    {       // Make a new vector in the corresponding direction
        Vector2 _direction = Vector2.left;
        Vector2 _directedPosition = (Vector2)transform.position + _direction;
            // Draw a ray for debugging
        Debug.DrawRay(transform.position, _direction, Color.green, 1000f);
            // Draw a physics Dot and if there is a gameobject report that back
        Collider2D _westCollider = Physics2D.OverlapPoint(_directedPosition);
        Debug.Log("West: " + _westCollider.gameObject);
    }

    protected void CheckPositionRelative(int x, int y)
    {       // Make a new vector in the corresponding direction
        Vector2 _direction = new Vector2(x, y);
        Vector2 _directedPosition = (Vector2)transform.position + _direction;
            // Draw a ray for debugging
        Debug.DrawRay(transform.position, _direction, Color.green, 1000f);
            // Draw a physics Dot and if there is a gameobject report that back
        Collider2D _customCollider = Physics2D.OverlapPoint(_directedPosition);
        Debug.Log("Custom: " + _customCollider.gameObject);
    }
}
