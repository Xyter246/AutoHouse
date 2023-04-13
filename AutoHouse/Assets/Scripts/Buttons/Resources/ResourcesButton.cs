using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesButton : GameManager
{
    [SerializeField] private GameObject _resourceButtonChild;
    [SerializeField] private static GameObject RESOURCEBUTTONCHILD;


    private void Awake()
    {
        RESOURCEBUTTONCHILD = _resourceButtonChild;
    }

    public static void OnClick()
    {
        func.SwitchActiveState(RESOURCEBUTTONCHILD);
    }
}