using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsButton : GameManager
{
    [SerializeField] private GameObject _settingsGui;
    public void OnClick()
    {
        func.SwitchActiveState(_settingsGui);
        if (_settingsGui.activeInHierarchy == true) { Time.timeScale = 0f; } else { Time.timeScale = 1f; }
    }
}
