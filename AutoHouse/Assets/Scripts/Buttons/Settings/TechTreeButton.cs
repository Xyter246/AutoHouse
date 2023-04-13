using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TechTreeButton : GameManager
{
    [SerializeField] private GameObject _techTreeGUI;

    public void OnClick()
    {
        func.SwitchActiveState(_techTreeGUI);
    }
}
