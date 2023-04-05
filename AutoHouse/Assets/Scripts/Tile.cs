using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color _baseColor, _offsetColor;
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private GameObject _highlight;
    GridManager gridManager = new GridManager();

    public void Init(bool isOffset) {
        _renderer.color = isOffset ? _offsetColor : _baseColor;
    }

    private void OnMouseDown()
    {
        Vector2 mousePosition = gridManager.GetMousePosition();
        Debug.Log("X: " + mousePosition.x + ", Y: " + mousePosition.y);
    //    gridManager.GetTileAtPosition(mousePosition);
    }

    #region "Highlighting Tiles"
    void OnMouseEnter()
    {
        _highlight.SetActive(true);
    }

    void OnMouseExit()
    {
        _highlight.SetActive(false);
    }
    #endregion
}