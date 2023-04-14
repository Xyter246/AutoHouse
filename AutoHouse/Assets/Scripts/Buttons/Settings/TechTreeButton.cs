using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TechTreeButton : GameManager
{
    [SerializeField] private GameObject _techTreeGUI;

    public void OnClick()
    {
        // If button is clicked, open or close Tech Tree GUI
        func.SwitchActiveState(_techTreeGUI);
    }
}
