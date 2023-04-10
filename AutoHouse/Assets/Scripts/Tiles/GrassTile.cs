using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class GrassTile : Tile
{
    [SerializeField] private Color _baseColor, _offsetColor;
    [SerializeField] private Tile _conveyor;

    public override void Init(int x, int y)
    { // Make the grass colors alternate like a chess board
        var isOffset = ((x + y) % 2 == 1);
        _renderer.color = isOffset ? _offsetColor : _baseColor;
    }

    private void Awake()
    {   // if grass tile was not made with GenerateGrid(), then get for Mouse position to check offset
        if (Time.timeSinceLevelLoadAsDouble > 0)
        {
            Init((int)func.GetMousePosition().x, (int)func.GetMousePosition().y);
        }
    }

    #region "Mouse Interactions"
    protected override void OnMouseDown()
    {   // Only execute if not over UI
        if (!func.IsCursorOverUIObject()) {
            // If you click on (open) grass tile, place SelectedBuildingType on that location
            if (SelectedBuildingType != null) {
                if (SelectedBuildingType == SelectedBuildingType.CompareTag("MinerTile")) {
                    UtilsClass.CreateWorldTextPopup("Not A Suitable Location! (Miners Can't Go On Grass)", func.GetMousePosition());
                } else if (SelectedBuildingType == _conveyor) {
                    Destroy(gameObject);
                    //gridManager.RotateTile();
                    Instantiate(SelectedBuildingType, transform.position, Quaternion.identity);
                } else {
                    Destroy(gameObject);
                    Instantiate(SelectedBuildingType, transform.position, Quaternion.identity);
                }
            }
        }
    }

    new private void OnMouseOver()
    { // placeholder, purpose is to NOT to something

    }
    #endregion 
}
