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
        SwitchActiveState(_coalButton);
        SwitchActiveState(_copperButton);
        SwitchActiveState(_goldButton);
        SwitchActiveState(_ironButton);
        SwitchActiveState(_stoneButton);
        SwitchActiveState(_woodButton);
    }

    public void SwitchActiveState(GameObject gameObject)
    {
        if (gameObject.activeInHierarchy == true) { 
            gameObject.SetActive(false);
        } else {
            gameObject.SetActive(true);
        }
    }
}
