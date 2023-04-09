using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Functions : MonoBehaviour
{
    public static Vector2 GetMousePosition()
    {
            // Get mouse position in pixels
        Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            // Transfer pixel location to world x and y
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
            // Round x and y to nearest integer
        Vector2 mousePosition = new Vector2(Mathf.Round(worldPosition.x), Mathf.Round(worldPosition.y));
        return mousePosition;
    }

    public static bool IsCursorOverUIObject()
    {       // Get pointer position
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            // Get every UI element that is under the pointer
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
            // If there are no UI elements (no items in results.Count) -> return false, 
        return results.Count > 0;
    }
    public void CheckNorth()
    {       // Make a new vector in the corresponding direction
        Vector2 _direction = Vector2.up;
        Vector2 _directedPosition = (Vector2)transform.position + _direction;
            // Draw a ray for debugging
        Debug.DrawRay(transform.position, _direction, Color.red, 1000f);
            // Draw a physics Dot and if there is a gameobject report that back
        Collider2D _northCollider = Physics2D.OverlapPoint(_directedPosition);
        Debug.Log("North: " + _northCollider.gameObject);
    }

    public void CheckEast()
    {       // Make a new vector in the corresponding direction
        Vector2 _direction = Vector2.right;
        Vector2 _directedPosition = (Vector2)transform.position + _direction;
            // Draw a ray for debugging
        Debug.DrawRay(transform.position, _direction, Color.cyan, 1000f);
            // Draw a physics Dot and if there is a gameobject report that back
        Collider2D _eastCollider = Physics2D.OverlapPoint(_directedPosition);
        Debug.Log("East: " + _eastCollider.gameObject);
    }

    public void CheckSouth()
    {       // Make a new vector in the corresponding direction
        Vector2 _direction = Vector2.down;
        Vector2 _directedPosition = (Vector2)transform.position + _direction;
            // Draw a ray for debugging
        Debug.DrawRay(transform.position, _direction, Color.white, 1000f);
            // Draw a physics Dot and if there is a gameobject report that back
        Collider2D _southCollider = Physics2D.OverlapPoint(_directedPosition);
        Debug.Log("South: " + _southCollider.gameObject);
    }

    public void CheckWest()
    {       // Make a new vector in the corresponding direction
        Vector2 _direction = Vector2.left;
        Vector2 _directedPosition = (Vector2)transform.position + _direction;
            // Draw a ray for debugging
        Debug.DrawRay(transform.position, _direction, Color.green, 1000f);
            // Draw a physics Dot and if there is a gameobject report that back
        Collider2D _westCollider = Physics2D.OverlapPoint(_directedPosition);
        Debug.Log("West: " + _westCollider.gameObject);
    }

    public void CheckPositionRelative(int x, int y)
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
