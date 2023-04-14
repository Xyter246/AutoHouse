using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class GameHotKeys : GameManager
{
    // Declare/Reference Variables (statics don't show up in the Editor)
    [SerializeField] private GameObject _playerBase;
    [SerializeField] private GameObject _inventoryGUI;
    [SerializeField] private GameObject _resourceButton;
    [SerializeField] private GameObject _settingsGUI;
    [SerializeField] private GameObject _controlsGUI;
    [SerializeField] private GameObject _techTreeGUI;
    [SerializeField] private GameObject _introductionGUI;
    public static int TileRotation;

    // boolean for custom resource tile placement
    [SerializeField] private bool _modularResources;
    public static bool MODULAR_RESOURCES;

    // Declare/Reference Different Buildings
    [SerializeField] private Tile _assemblerTile;
    [SerializeField] private Tile _warehouseTile;
    [SerializeField] private Tile _conveyorTile;
    [SerializeField] private Tile _minerTile;

    // Declare/Reference Different Resource Tile
    [SerializeField] private Tile _coalTile;
    [SerializeField] private Tile _copperTile;
    [SerializeField] private Tile _goldTile;
    [SerializeField] private Tile _ironTile;
    [SerializeField] private Tile _stoneTile;
    [SerializeField] private Tile _woodTile;    

    private void Awake()
    {
        // Set the static variable to the serialized variable
        MODULAR_RESOURCES = _modularResources;
        _introductionGUI.SetActive(true);
    }

    void Update()
    {
        // if not holding LeftShift
        if (!Input.GetKey(KeyCode.LeftShift)) {

            // If 'R' is pressed. Rotate SelectedBuildingType
            if (Input.GetKeyDown(KeyCode.R)) {
               // rotate the 'rotation variable' Clockwise
               if (TileRotation == 0) { TileRotation = 90; } else
               if (TileRotation == 90) { TileRotation = 180; } else
               if (TileRotation == 180) { TileRotation = 270; } else
               if (TileRotation == 270) { TileRotation = 0; }
            }

            // If 'E' is pressed. Open and close Inventory
            if (Input.GetKeyDown(KeyCode.E)) { InventoryButton.OnClick(); }
            // If 'E' is pressed. Open and close Resources
            if (Input.GetKeyDown(KeyCode.F)) { ResourcesButton.OnClick(); }
            // If 'P' is pressed. Switch between active states of Player
            if (Input.GetKeyDown(KeyCode.P)) { func.SwitchActiveState(_playerBase); }
            // If 'T' is pressed. And Controls GUI isn't already enabled. Enable or disable the 'TechTree' (, sadly not really a techtree) 
            if (!_controlsGUI.activeInHierarchy) {
                if (Input.GetKeyDown(KeyCode.T)) { func.SwitchActiveState(_techTreeGUI); }
            }
            // If 'M' is pressed and MODULAR_RESOURCES == true. Switch between Modular Resources
            if (MODULAR_RESOURCES) { 
                if (Input.GetKeyDown(KeyCode.M)) { func.SwitchActiveState(_resourceButton); } 
            }

            // If 'ESC' (Escape) is pressed...
            if (Input.GetKeyDown(KeyCode.Escape)) { 
                // ...deactivate Controls GUI,
                if (_controlsGUI.activeInHierarchy) { _controlsGUI.SetActive(false); }
                // ...or deactivate Tech Tree GUI, 
                else if (_techTreeGUI.activeInHierarchy) { _techTreeGUI.SetActive(false); }
                // ...or deactivate Settings GUI, 
                else if (_settingsGUI.activeInHierarchy) { SettingsButton.OnClick(); }
                // ...or active Settings GUI
                else if (!_settingsGUI.activeInHierarchy) { SettingsButton.OnClick(); }
            }

            // If '1' is pressed. Select Assembler
            if (Input.GetKeyDown(KeyCode.Alpha1)) { SelectedBuildingType = _conveyorTile; }
            // If '2' is pressed. Select Warehouse
            if (Input.GetKeyDown(KeyCode.Alpha2)) { SelectedBuildingType = _warehouseTile; }
            // If '3' is pressed. Select Conveyor
            if (Input.GetKeyDown(KeyCode.Alpha3)) { SelectedBuildingType = _minerTile; }
            // If '4' is pressed. Select Miner
            if (Input.GetKeyDown(KeyCode.Alpha4)) { SelectedBuildingType = _assemblerTile; }
        }

        #region ShiftKey
        /////////////////////////////////////////////////
        //                                             //
        //-------For every Hotkey with any SHIFT-------//
        //                                             //
        /////////////////////////////////////////////////

        if (Input.GetKey(KeyCode.LeftShift)) {
            if (Input.GetKeyDown(KeyCode.R)) {
                // rotate the 'rotation variable' Counter-Clockwise
                if (TileRotation == 0) { TileRotation = 270; } else
                if (TileRotation == 90) { TileRotation = 0; } else
                if (TileRotation == 180) { TileRotation = 90; } else
                if (TileRotation == 270) { TileRotation = 180; }
            }

            // Only allow these hotkeys is MODULAR_RESOURCES is enabled (default == true)
            if (MODULAR_RESOURCES == true) {
                // If 'Shift + 1' is pressed. Select Wood Tile
                if (Input.GetKeyDown(KeyCode.Alpha1)) { SelectedBuildingType = _woodTile; }
                // If 'Shift + 2' is pressed. Select Stone Tile
                if (Input.GetKeyDown(KeyCode.Alpha2)) { SelectedBuildingType = _stoneTile; }
                // If 'Shift + 3' is pressed. Select Coal Tile
                if (Input.GetKeyDown(KeyCode.Alpha3)) { SelectedBuildingType = _coalTile; }
                // If 'Shift + 4' is pressed. Select Copper Tile
                if (Input.GetKeyDown(KeyCode.Alpha4)) { SelectedBuildingType = _copperTile; }
                // If 'Shift + 5' is pressed. Select Iron Tile
                if (Input.GetKeyDown(KeyCode.Alpha5)) { SelectedBuildingType = _ironTile; }
                // If 'Shift + 6' is pressed. Select Gold Tile
                if (Input.GetKeyDown(KeyCode.Alpha6)) { SelectedBuildingType = _goldTile; }
            }
        }
        #endregion
        /////////////////////////////////////////////////
        //                                             //
        //-------------And Other Controls--------------//
        //                                             //
        /////////////////////////////////////////////////
        ///
        /// WASD for moving Player Character
        /// Mouse Scroll Wheel for (Game) camera zoom in and out
        /// Right Mouse Button to remove Tiles
        /// Left Mouse Button to place selected Tiles
        
    }
}