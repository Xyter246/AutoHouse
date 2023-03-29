using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomScrollWheel : MonoBehaviour
{
    [SerializeField] private float ScrollSpeed = 10f;
    [SerializeField] private float minZoom = 5f;
    [SerializeField] private float maxZoom = 30f;
    private Camera ZoomCamera;

    private void Start() {
        ZoomCamera = Camera.main;
    }
    
    private void Update(){
        // Let player zoom in and out
        if (Input.GetAxis("Mouse ScrollWheel") != 0) {
            if (ZoomCamera.orthographicSize >= minZoom && ZoomCamera.orthographicSize <= maxZoom) {
                ZoomCamera.orthographicSize -= Input.GetAxis("Mouse ScrollWheel") * ScrollSpeed;
            }
            // Set a maximum and minimum zoom distance
            if (ZoomCamera.orthographicSize < minZoom)
            {
                ZoomCamera.orthographicSize = minZoom;
            }
            if (ZoomCamera.orthographicSize > maxZoom)
            {
                ZoomCamera.orthographicSize = maxZoom;
            }
        }
    }
}
