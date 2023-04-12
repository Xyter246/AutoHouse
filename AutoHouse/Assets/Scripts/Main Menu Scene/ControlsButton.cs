using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsButton : MonoBehaviour
{
    [SerializeField] private GameObject _controlsGUI;
    Functions func = new();
    public void OnClick()
    {
        func.SwitchActiveState(_controlsGUI);
    }
}
