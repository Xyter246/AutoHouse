using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesButton : GameManager
{
    [SerializeField] private GameObject _woodButton;
    [SerializeField] private static GameObject WOOD_BUTTON;
    [SerializeField] private GameObject _stoneButton;
    [SerializeField] private static GameObject STONE_BUTTON;
    [SerializeField] private GameObject _coalButton;
    [SerializeField] private static GameObject COAL_BUTTON;
    [SerializeField] private GameObject _copperButton;
    [SerializeField] private static GameObject COPPER_BUTTON;
    [SerializeField] private GameObject _ironButton;
    [SerializeField] private static GameObject IRON_BUTTON;
    [SerializeField] private GameObject _goldButton;
    [SerializeField] private static GameObject GOLD_BUTTON;

    private void Awake()
    {
        WOOD_BUTTON = _woodButton;
        STONE_BUTTON = _stoneButton;
        COAL_BUTTON = _coalButton;
        COPPER_BUTTON = _copperButton;
        IRON_BUTTON = _ironButton;
        GOLD_BUTTON = _goldButton;
    }

    public static void OnClick()
    {
        func.SwitchActiveState(WOOD_BUTTON);
        func.SwitchActiveState(STONE_BUTTON);
        func.SwitchActiveState(COAL_BUTTON);
        func.SwitchActiveState(COPPER_BUTTON);
        func.SwitchActiveState(IRON_BUTTON);
        func.SwitchActiveState(GOLD_BUTTON);
    }
}