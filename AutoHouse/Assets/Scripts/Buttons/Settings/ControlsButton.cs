using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsButton : GameManager
{
    [SerializeField] private GameObject _controlsGUI;

    public void OnClick()
    {
        // If Clicked, enable or disable Controls GUI
        func.SwitchActiveState(_controlsGUI);
    }
}
