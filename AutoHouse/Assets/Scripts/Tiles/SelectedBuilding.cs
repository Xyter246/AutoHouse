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
        if (SelectedBuildingType != null) {
            SelectedBuildingChild.GetComponent<Image>().overrideSprite = SelectedBuildingType.GetComponent<SpriteRenderer>().sprite;
        } else {
            SelectedBuildingChild.GetComponent<Image>().overrideSprite = _whiteSquare;
        }
    }
}