using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsButton : GameManager
{
    [SerializeField] private GameObject _controlsGUI;

    public void OnClick()
    {
        func.SwitchActiveState(_controlsGUI);
    }
}
