using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompassGUI : MonoBehaviour
{
    [SerializeField] Image image;

    [SerializeField] Sprite _north;
    [SerializeField] Sprite _east;
    [SerializeField] Sprite _south;
    [SerializeField] Sprite _west;

    private void Update()
    {
        // Rotate the compass to correspond with currently selected place direction (Used for conveyors)
        if (GameHotKeys.TileRotation == 0) { image.sprite = _north; }
        if (GameHotKeys.TileRotation == 90) { image.sprite = _east; }
        if (GameHotKeys.TileRotation == 180) { image.sprite = _south; }
        if (GameHotKeys.TileRotation == 270) { image.sprite = _west; }
    }
}
