using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsButton : GameManager
{
    [SerializeField] private GameObject _settingsGui;
    private static GameObject settingsGui;

    private void Awake()
    {
        // Set static variable equal to private serializable variable
        settingsGui = _settingsGui;
    }

    public static void OnClick()
    {
        // If clicked, enable or disable Settings GUI. If enabled, stop time.
        func.SwitchActiveState(settingsGui);
        if (settingsGui.activeInHierarchy == true) { Time.timeScale = 0f; } else { Time.timeScale = 1f; }
    }
}
