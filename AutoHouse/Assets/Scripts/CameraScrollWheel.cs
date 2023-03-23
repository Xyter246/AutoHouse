using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraScrollWheel : MonoBehaviour
{
    [SerializeField] private float ScrollSpeed = 10f;
    private Camera ZoomCamera;

    private void Start() {
        ZoomCamera = Camera.main;
    }
    
    private void Update(){
        if (ZoomCamera.orthographicSize >= 15f || ZoomCamera.orthographicSize <= 70f)
        {
            ZoomCamera.orthographicSize -= Input.GetAxis("Mouse ScrollWheel") * ScrollSpeed;   
        }
        if (ZoomCamera.orthographicSize < 15f) {
            Debug.Log("Below Allowed Zoom!");
        }
        if (ZoomCamera.orthographicSize < 70f) {
            Debug.Log("Above Allowed Zoom!");
        }
    }
}
