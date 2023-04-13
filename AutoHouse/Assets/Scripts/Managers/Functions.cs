using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Functions : MonoBehaviour
{
    public Vector2 GetRoundedMousePosition()
    {
        // Get mouse position in pixels
        Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        // Transfer pixel location to world x and y
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
        // Round x and y to nearest integer
        Vector2 mousePosition = new Vector2(Mathf.Round(worldPosition.x), Mathf.Round(worldPosition.y));
        return mousePosition;
    }

    public void SwitchActiveState(GameObject gameObject)
    {
        // if the gameobject is Active
        if (gameObject.activeInHierarchy == true) {
            // Deactivate it
            gameObject.SetActive(false);
        } else {
            // if it isn't active, activate it
            gameObject.SetActive(true);
        }
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
        // Get X coordinate and round it to the nearest integer
        int x = (int)Mathf.Round(go.transform.position.x);
        // Get Y coordinate and round it to the nearest integer
        int y = (int)Mathf.Round(go.transform.position.y);
        // Return output
        Vector2Int output = new Vector2Int(x, y);
        return output;
    }

    #region "Checks Around Tiles"
    public List<GameObject> GetObjectsOnMyDotPosition(GameObject go, Vector2? _slightOffset = null)    
    {
        // If _slightOffset isn't given
        if (_slightOffset == null) { _slightOffset = Vector2.zero; }

        // Method:
        Vector3 _directedPosition = go.transform.position + (Vector3)_slightOffset;
        // Draw a physics Dot and save the colliders that hit it in an array
        Collider2D[] _customColliderArray = Physics2D.OverlapPointAll(_directedPosition);
        List<GameObject> gameObjects = new ();
        // Add every item in the array as a gameobject to a list
        foreach (Collider2D collider2D in _customColliderArray) {
            gameObjects.Add(collider2D.gameObject);
        }
        // return that list
        return gameObjects;
    }

    public List<GameObject> GetObjectsInBox(
        #nullable enable 
        GameObject? go = null, 
        #nullable disable 
        Vector2? _origin = null, Vector2? _boxSize = null, float? _angle = null)
    {
        // If overloads aren't given
        if (_origin == null) { _origin = go.transform.position; }
        if (_boxSize == null) { _boxSize = new Vector2(0.9f, 0.9f); }
        if (_angle == null) { _angle = 0f; }

        // Method:
        Vector3 _position = (Vector2)_origin;

        // Create a physics Rectangle (can be a line) and save the colliders that hit it in an array
        Collider2D[] _boxColliderArray = Physics2D.OverlapBoxAll(_position, (Vector2)_boxSize, (float)_angle);
        List<GameObject> boxColliderList = new ();
        // Add every item in the array as a gameobject to a list
        foreach (var obj in _boxColliderArray) {
            boxColliderList.Add(obj.gameObject);
        }
        // return that list
        return boxColliderList;
    }

    // Dynamic Overload method, ability to choose color, or to not choose it
    public List<GameObject> GetRelativePosition(GameObject go, Vector2 _direction, Color? _color = null)
    {       
        if (_color == null) { _color = Color.red; }
        // Make a new vector in the correspondense with direction
        Vector2 _directedPosition = (Vector2)go.transform.position + _direction;
        // Draw a ray for debugging
        Debug.DrawRay(go.transform.position, new Vector3(_direction.x, _direction.y, -5), (Color)_color, 1000f);
        // Draw a physics Dot and save the colliders that hit it in an array
        Collider2D[] _customColliderArray = Physics2D.OverlapPointAll(_directedPosition);
        List<GameObject> gameObjects = new ();
        // Add every item in the array as a gameobject to a list
        foreach (Collider2D collider2D in _customColliderArray) {
            gameObjects.Add(collider2D.gameObject);
        }
        // return that list
        return gameObjects;
    }
    #endregion

    public bool IsThisGameObjectLocked(GameObject gameobject)
    {   
        // if the gameobject has Locked (Child), then the gameObject must be Locked and should not be available
        if (gameobject.transform.Find("Locked").gameObject != null) { return true; } 
        // if it isn't locked, return false
        else return false;
    }
}
