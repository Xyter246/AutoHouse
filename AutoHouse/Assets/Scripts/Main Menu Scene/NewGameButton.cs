using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameButton : MonoBehaviour
{
    [SerializeField] private string _newGameWorld;
    public void OnClick()
    {
        SceneManager.LoadScene(_newGameWorld);
    }
}
