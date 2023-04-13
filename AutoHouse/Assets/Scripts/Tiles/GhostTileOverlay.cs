using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class GhostTileOverlay : GameManager
{
    [SerializeField] private Tile _assemblerTile;
    [SerializeField] private Tile _warehouseTile;
    [SerializeField] private Tile _conveyorTile;
    [SerializeField] private Tile _minerTile;
    [SerializeField] private Tile _woodTile;
    [SerializeField] private Tile _stoneTile;
    [SerializeField] private Tile _coalTile;
    [SerializeField] private Tile _copperTile;
    [SerializeField] private Tile _ironTile;
    [SerializeField] private Tile _goldTile;
    private Sprite _ghostOverlay;
    private Vector2 _mousePos;
    private Vector2 _lastMousePos;

    void Update()
    {
        if (GetSprite(SelectedBuildingType) != _ghostOverlay) {
            if (SelectedBuildingType == null) { _ghostOverlay = null; } else
            if (SelectedBuildingType == _assemblerTile) { _ghostOverlay = GetSprite(_assemblerTile); } else
            if (SelectedBuildingType == _warehouseTile) { _ghostOverlay = GetSprite(_warehouseTile); } else
            if (SelectedBuildingType == _conveyorTile) { _ghostOverlay = GetSprite(_conveyorTile); } else
            if (SelectedBuildingType == _minerTile) { _ghostOverlay = GetSprite(_minerTile); } else
            if (SelectedBuildingType == _woodTile) { _ghostOverlay = GetSprite(_woodTile); } else
            if (SelectedBuildingType == _stoneTile) { _ghostOverlay = GetSprite(_stoneTile); } else
            if (SelectedBuildingType == _coalTile) { _ghostOverlay = GetSprite(_coalTile); } else
            if (SelectedBuildingType == _copperTile) { _ghostOverlay = GetSprite(_copperTile); } else
            if (SelectedBuildingType == _ironTile) { _ghostOverlay = GetSprite(_ironTile); } else
            if (SelectedBuildingType == _goldTile) { _ghostOverlay = GetSprite(_goldTile); }
        }

        _mousePos = func.GetRoundedMousePosition();
        if (_mousePos != _lastMousePos) {
            Instantiate(_ghostOverlay, _mousePos, Quaternion.identity);
            _lastMousePos = _mousePos;
        }
    }

    private Sprite GetSprite(Tile tile)
    {
        Sprite _sprite = tile.gameObject.GetComponent<SpriteRenderer>().sprite;
        Debug.Log(_sprite);
        return _sprite;
    }
}
