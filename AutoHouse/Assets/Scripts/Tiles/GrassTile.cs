using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassTile : Tile
{
    [SerializeField] private Color _baseColor, _offsetColor;

    public override void Init(int x, int y)
    {
        var isOffset = (x + y) % 2 == 1;
        _renderer.color = isOffset ? _offsetColor : _baseColor;
    }

    new private void OnMouseDown()
    {
        if (SelectedBuildingType != null) {
            Vector2 mousePosition = gridManager.GetMousePosition();
            Debug.Log("X: " + mousePosition.x + ", Y: " + mousePosition.y);
            Destroy(gameObject);
            Instantiate(SelectedBuildingType, transform.position, Quaternion.identity);
        }
    }
}
