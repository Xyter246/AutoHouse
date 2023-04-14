using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SelectedBuilding : GameManager
{
    [SerializeField] private GameObject SelectedBuildingChild;
    [SerializeField] private Sprite _whiteSquare;

    void Update()
    {
        // If there is a SelectedBuildingType selected
        if (SelectedBuildingType != null) {
            // Set the image Bottom-Right to that Tile
            SelectedBuildingChild.GetComponent<Image>().overrideSprite = SelectedBuildingType.GetComponent<SpriteRenderer>().sprite;
        } else {
            // Else set the image Bottom-Right to nothing
            SelectedBuildingChild.GetComponent<Image>().overrideSprite = _whiteSquare;
        }
    }
}