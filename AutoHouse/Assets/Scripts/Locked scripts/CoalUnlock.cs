using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoalUnlock : GameManager
{
    [SerializeField] private GameObject _coalButton;
    [SerializeField] private GameObject _coalUnlock;
    [SerializeField] private GameObject _copperButton;
    [SerializeField] private GameObject _coalInventory1;
    [SerializeField] private GameObject _coalInventory2;
    private GameObject _locked;

    public void OnClick()
    {
        // If UNLOCK gets clicked on Coal Miner research, and there are enough resources
        if (AMOUNT_WOOD >= 40 && AMOUNT_STONE >= 30) {
            AMOUNT_WOOD -= 40;
            AMOUNT_STONE -= 30;

            // Disable every thing that hides coal...
            _coalUnlock.SetActive(false); // can Destroy, because it will never be needed again in the same game
            _coalInventory1.SetActive(true);
            _coalInventory2.SetActive(true);
            // ...and enable the next research part
            _copperButton.SetActive(true);

            // Actually remove the Lock
            _locked = _coalButton.transform.Find("Locked").gameObject;
            Destroy(_locked);
        }
    }
}