using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tile : GameManager
{
    [SerializeField] protected SpriteRenderer _renderer;
    [SerializeField] private GameObject _highlight;
    protected GridManager gridManager = new GridManager();

    public virtual void Init(int x, int y)
    {
    }

    protected void OnMouseDown()
    {
        Vector2 mousePosition = gridManager.GetMousePosition();
        Debug.Log("X: " + mousePosition.x + ", Y: " + mousePosition.y);

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
