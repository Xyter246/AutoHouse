using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryButton : GameManager
{
    [SerializeField] private static GameObject inventoryGUI;
    [SerializeField] private GameObject _inventoryGUI;
    [SerializeField] private static GameObject inventoryGUI2;
    [SerializeField] private GameObject _inventoryGUI2;

    // Method to access the toggle value
    public void NewInventoryGUIToggle(bool _newInventoryGUIToggle) {
        NEW_INVENTORY_MODE = _newInventoryGUIToggle;
        inventoryGUI.SetActive(false);
        inventoryGUI2.SetActive(false);
    }

    private void Awake()
    {
        // replace this value with whatever _newInventoryGUIToggle is when starting the game
        NEW_INVENTORY_MODE = true;
        // Set static references to the correct gameobjects
        inventoryGUI = _inventoryGUI;
        inventoryGUI2 = _inventoryGUI2;
    }

    public static void OnClick()
    {
        // Which inventory mode is selected will be used when inventory button is clicked
        if (NEW_INVENTORY_MODE) { func.SwitchActiveState(inventoryGUI2); inventoryGUI.SetActive(false); }
        if (!NEW_INVENTORY_MODE) { func.SwitchActiveState(inventoryGUI); inventoryGUI2.SetActive(false); }
        // The .SetActive(false) is precautionairy, if the incorrect one were to be active, deactivate it when you use the button again.
    }
}