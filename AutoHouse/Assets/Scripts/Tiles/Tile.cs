using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public abstract class Tile : GameManager
{
    [SerializeField] protected SpriteRenderer _renderer; // must be 'protected'
    [SerializeField] private Tile _replaceTile;
    [SerializeField] private GameObject _highlight;

    public virtual void Init(int x, int y)
    {   // placeholder, purpose is to NOT to something

    }

    #region "Mouse Interactions"
    protected void OnMouseOver()
    {   // Only execute if not over UI
        if (!func.IsCursorOverUIObject()) {
            // On RMB, then destroy object and replace with replaceobject (standard is grass)
            if (Input.GetKey(KeyCode.Mouse1)) {
                // Destroy selected gameObject
                Destroy(gameObject);

                // Make a replace tile (grass) and name it accordingly "Tile [x] [y]"
                _replaceTile.name = $"Tile {func.GetRoundedMousePosition().x} {func.GetRoundedMousePosition().y}";
                Instantiate(_replaceTile, transform.position, Quaternion.identity);
            }
        }
    }

    protected virtual void OnMouseDown()
    {   // Only execute if not over UI
        if (!func.IsCursorOverUIObject() && SelectedBuildingType != null) {
            // If you click on a any tile that isn't made to have something placed on it (like buildings), log that
            UtilsClass.CreateWorldTextPopup("Not A Suitable Location! \n(Something is already there!)", func.GetRoundedMousePosition(), 4f);
        }
    }

    #endregion

    #region "Highlighting Tiles"
    // Standard Highlighting logic, works for every Tile, although sometimes barely noticable (Conveyor mostly)
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
