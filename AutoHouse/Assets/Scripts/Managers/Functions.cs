using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Functions : MonoBehaviour
{
    public Vector2 GetMousePosition()
    {
            // Get mouse position in pixels
        Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            // Transfer pixel location to world x and y
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
            // Round x and y to nearest integer
        Vector2 mousePosition = new Vector2(Mathf.Round(worldPosition.x), Mathf.Round(worldPosition.y));
        return mousePosition;
    }

    public bool IsCursorOverUIObject()
    {       // Get pointer position
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            // Get every UI element that is under the pointer
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
            // If there are no UI elements (no items in results.Count) -> return false, 
        return results.Count > 0;
    }

    #region "Checks Around Tiles"
    public List<GameObject> GetObjectsOnMyPosition(GameObject go)
    {
        List<GameObject> gameObjects = new List<GameObject>();
        Vector3 _directedPosition = go.transform.position;
        Vector3 _direction = Vector3.zero;
            // Draw a ray for debugging
        Debug.DrawRay(go.transform.position, _direction, Color.green, 1000f);
            // Draw a physics Dot and if there is a gameobject report that back
        Collider2D[] _customColliderArray = Physics2D.OverlapPointAll(_directedPosition);
        foreach (Collider2D collider2D in _customColliderArray) {
            gameObjects.Add(collider2D.gameObject);
        }
        return gameObjects;
    }

    public List<GameObject> CheckPositionRelative(int x, int y)
    {       
        List<GameObject> gameObjects = new List<GameObject>();
            // Make a new vector in the corresponding direction
        Vector2 _direction = new Vector2(x, y);
        Vector2 _directedPosition = (Vector2)transform.position + _direction;
            // Draw a ray for debugging
        Debug.DrawRay(transform.position, _direction, Color.green, 1000f);
            // Draw a physics Dot and if there is a gameobject report that back
        Collider2D[] _customColliderArray = Physics2D.OverlapPointAll(_directedPosition);
        foreach (Collider2D collider2D in _customColliderArray) {
            gameObjects.Add(collider2D.gameObject);
        }
        return gameObjects;
    }
    #endregion
}
