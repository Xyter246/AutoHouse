using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopperUnlock : GameManager
{
    [SerializeField] private GameObject _copperButton;
    [SerializeField] private GameObject _copperUnlock;
    [SerializeField] private GameObject _ironButton;
    [SerializeField] private GameObject _copperInventory1;
    [SerializeField] private GameObject _copperInventory2;
    private GameObject _locked;

    public void OnClick()
    {
        // If UNLOCK gets clicked on Copper Miner research, and there are enough resources
        if (AMOUNT_STONE >= 25 && AMOUNT_COAL >= 35) {
            AMOUNT_STONE -= 25;
            AMOUNT_COAL -= 35;

            // Disable every thing that hides copper...
            _copperUnlock.SetActive(false); // can Destroy, because it will never be needed again in the same game
            _copperInventory1.SetActive(true);
            _copperInventory2.SetActive(true);
            // ...and enable the next research part
            _ironButton.SetActive(true);

            // Actually remove the Lock
            _locked = _copperButton.transform.Find("Locked").gameObject;
            Destroy(_locked);
        }
    }
}