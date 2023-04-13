using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronUnlock : GameManager
{
    [SerializeField] private GameObject _ironButton;
    [SerializeField] private GameObject _ironUnlock;
    [SerializeField] private GameObject _goldButton;
    [SerializeField] private GameObject _ironInventory1;
    [SerializeField] private GameObject _ironInventory2;
    private GameObject _locked;

    public void OnClick()
    {
        // If UNLOCK gets clicked on Iron Miner research, and there are enough resources
        if (AMOUNT_STONE >= 60 && AMOUNT_COAL >= 40 && AMOUNT_COPPER >= 15) {
            AMOUNT_STONE -= 60;
            AMOUNT_COAL -= 40;
            AMOUNT_COPPER -= 15;

            // Disable every thing that hides iron...
            _ironUnlock.SetActive(false); // can Destroy, because it will never be needed again in the same game
            _ironInventory1.SetActive(true);
            _ironInventory2.SetActive(true);
            // ...and enable the next research part
            _goldButton.SetActive(true);

            // Actually remove the Lock
            _locked = _ironButton.transform.Find("Locked").gameObject;
            Destroy(_locked);
        }
    }
}