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

    public Vector2Int GetRoundedGridPosition(GameObject go)
    {
        int x = (int)Mathf.Round(go.transform.position.x);
        int y = (int)Mathf.Round(go.transform.position.y);
        Vector2Int output = new Vector2Int(x, y);
        return output;
    }

    #region "Checks Around Tiles"
    public List<GameObject> GetObjectsOnMyPosition(GameObject go, Vector2? _slightOffset = null)    
    {
        // If _slightOffset isn't given
        if (_slightOffset == null) { _slightOffset = Vector2.zero; }

        // Method:
        Vector3 _directedPosition = go.transform.position + (Vector3)_slightOffset;
            // Draw a physics Dot and if there is a gameobject report that back
        Collider2D[] _customColliderArray = Physics2D.OverlapPointAll(_directedPosition);
        List<GameObject> gameObjects = new List<GameObject>();
        foreach (Collider2D collider2D in _customColliderArray) {
            gameObjects.Add(collider2D.gameObject);
        }
        return gameObjects;
    }

    //public List<GameObject> GetObjects(GameObject go, Vector2? _boxSize = null, float _angle, Vector2 _direction)
    //{
    //    // If _slightOffset isn't given
    //    if (_boxSize == null) { _boxSize = new Vector2(1, 1); }

    //    // Method:
    //    Vector3 _position = go.transform.position;
    //    // Draw a physics Dot and if there is a gameobject report that back
    //    RaycastHit2D[] _customColliderArray = Physics2D.BoxCastAll(_position, (Vector2)_boxSize, _angle, _direction);
    //    List<GameObject> gameObjects = new List<GameObject>();
    //    foreach (RaycastHit2D collider2D in _customColliderArray) {
    //        gameObjects.Add(collider2D.gameObject);
    //    }
    //    return gameObjects;
    //}

    // Dynamic Overload method, ability to choose color, or to not choose it
    public List<GameObject> GetRelativePosition(GameObject go, Vector2 _direction, Color? _color = null)
    {       
        if (_color == null) { _color = Color.red; }
             // Make a new vector in the correspondense with direction
        Vector2 _directedPosition = (Vector2)go.transform.position + _direction;
            // Draw a ray for debugging
        Debug.DrawRay(go.transform.position, new Vector3(_direction.x, _direction.y, -5), (Color)_color, 1000f);
            // Draw a physics Dot and if there is a gameobject report that back
        Collider2D[] _customColliderArray = Physics2D.OverlapPointAll(_directedPosition);
        List<GameObject> gameObjects = new List<GameObject>();
        foreach (Collider2D collider2D in _customColliderArray) {
            gameObjects.Add(collider2D.gameObject);
        }
        return gameObjects;
    }
    #endregion
}
