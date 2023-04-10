using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryButton : GameManager
{
    [SerializeField] private GameObject _inventoryGUI;

    public void OnClick()
    {
        func.SwitchActiveState(_inventoryGUI);

    }
}