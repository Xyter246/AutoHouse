using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuHotKeys : MonoBehaviour
{
    [SerializeField] private GameObject _controlsGUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            // ...deactivate Controls GUI, else
            if (_controlsGUI.activeInHierarchy) { _controlsGUI.SetActive(false); }
        }
    }
}
