using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesButton : GameManager
{
    [SerializeField] private GameObject _resourceButtonChild;
    [SerializeField] private static GameObject RESOURCEBUTTONCHILD;


    private void Awake()
    {
        // set the public static variable equal to the private serializable variable
        RESOURCEBUTTONCHILD = _resourceButtonChild;
    }

    public static void OnClick()
    {
        // If button is clicked, activate or deactive the ore tiles menu
        func.SwitchActiveState(RESOURCEBUTTONCHILD);
    }
}