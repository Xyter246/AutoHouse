using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraScrollWheel : MonoBehaviour
{
    DefaultControl defaultControl;
    float mouseScrollY;

    private void Awake() {
        defaultControl = new DefaultControl();
        defaultControl.Zoom.mouseScrollY.performed += x => mouseScrollY = x.ReadValue<float>();
    }

    void Update() {
        if (mouseScrollY > 0) {
            Debug.Log("Scrolled Up!");
        }

        if (mouseScrollY < 0) {
            Debug.Log("Scrolled Down!");
        }
    }

    #region - Enable / Disable -
        void OnEnable() {
            defaultControl.Enable();
        }

        void OnDisable() {
            defaultControl.Disable();
        }
    #endregion
}
