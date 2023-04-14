using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroPopUp : MonoBehaviour
{
    [SerializeField] private GameObject _helpingPopUp;

    private void OnDestroy()
    {
        _helpingPopUp.SetActive(true);
    }
}
