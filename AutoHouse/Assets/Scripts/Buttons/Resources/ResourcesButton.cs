using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesButton : GameManager
{
    [SerializeField] private GameObject _coalButton;
    [SerializeField] private GameObject _copperButton;
    [SerializeField] private GameObject _goldButton;
    [SerializeField] private GameObject _ironButton;
    [SerializeField] private GameObject _stoneButton;
    [SerializeField] private GameObject _woodButton;

    private void OnClick()
    {
        func.SwitchActiveState(_coalButton);
        func.SwitchActiveState(_copperButton);
        func.SwitchActiveState(_goldButton);
        func.SwitchActiveState(_ironButton);
        func.SwitchActiveState(_stoneButton);
        func.SwitchActiveState(_woodButton);
    }
}
