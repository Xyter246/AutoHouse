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
    {
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
        return results.Count > 0;
    }
}
