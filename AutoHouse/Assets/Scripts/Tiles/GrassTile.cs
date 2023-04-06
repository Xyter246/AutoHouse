using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassTile : Tile
{
    [SerializeField] private Color _baseColor, _offsetColor;

    public override void Init(int x, int y)
    { // Make the grass colors alternate like a chess board
        var isOffset = ((x + y) % 2 == 1);
        _renderer.color = isOffset ? _offsetColor : _baseColor;
    }

    private void Awake()
    {   // if grass tile was not made with Init(), then get for Mouse position to check offset
        if (Time.timeSinceLevelLoadAsDouble > 0)
        {
            Init((int)Functions.GetMousePosition().x, (int)Functions.GetMousePosition().y);
        }
    }

    #region "Mouse Interactions"
    new private void OnMouseDown()
    {   // Only execute if not over UI
        if (!Functions.IsCursorOverUIObject()) {
            if (SelectedBuildingType != null /*&& SelectedBuildingType != MinerTile*/)
            {
                Destroy(gameObject);
                Instantiate(SelectedBuildingType, transform.position, Quaternion.identity);
            }
        }
    }

    new private void OnMouseOver()
    { // placeholder, purpose is to NOT to something

    }
    #endregion 
}
