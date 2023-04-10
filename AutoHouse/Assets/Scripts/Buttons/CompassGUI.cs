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

    private void Awake()
    {
        image.color = new Vector4(255, 255, 255, 255);
    }

    private void Update()
    {
        if (GridManager.TileRotation == 0) { image.sprite = _north; }
        if (GridManager.TileRotation == 90) { image.sprite = _east; }
        if (GridManager.TileRotation == 180) { image.sprite = _south; }
        if (GridManager.TileRotation == 270) { image.sprite = _west; }
    }
}
