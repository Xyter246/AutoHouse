using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

////////////////////////////////////////////////////////////////////////
///                                                                  ///
/// This Script is currently Unused, but kept for future endeavours. ///
///                                                                  ///
////////////////////////////////////////////////////////////////////////

public class ErrorMSGs : GameManager
{
    private static GameObject CURRENT_ERROR;
    [SerializeField] private GameObject _minerError;
    private static GameObject MINER_ERROR;
    [SerializeField] private GameObject _SmthintheWayError;
    private static GameObject _SMTH_INTHE_WAY_ERROR;

    private void Awake()
    {
        MINER_ERROR = _minerError;
        _SMTH_INTHE_WAY_ERROR = _SmthintheWayError;
    }

    public static void ErrorMSGMiner()
    {
        CURRENT_ERROR = MINER_ERROR.gameObject;
        Instantiate(CURRENT_ERROR);
        Destroy(CURRENT_ERROR, 5f);
    }

    public static void ErrorMSGSmthintheWay()
    {
        CURRENT_ERROR = _SMTH_INTHE_WAY_ERROR.gameObject;
        Instantiate(CURRENT_ERROR);
        Destroy(CURRENT_ERROR, 5f);
    }
}