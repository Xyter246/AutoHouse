using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldUnlock : GameManager
{
    [SerializeField] private GameObject _goldButton;
    [SerializeField] private GameObject _goldUnlock;
    [SerializeField] private GameObject _assemblerButton;
    [SerializeField] private GameObject _goldInventory1;
    [SerializeField] private GameObject _goldInventory2;
    private GameObject _locked;

    public void OnClick()
    {
        // If UNLOCK gets clicked on Gold Miner research, and there are enough resources
        if (AMOUNT_COPPER >= 85 && AMOUNT_IRON >= 115) {

            // Disable every thing that hides gold...
            _goldUnlock.SetActive(false); // can Destroy, because it will never be needed again in the same game
            _goldInventory1.SetActive(true);
            _goldInventory2.SetActive(true);
            // ...and enable the next research part
            _assemblerButton.SetActive(true);

            // Actually remove the Lock
            _locked = _goldButton.transform.Find("Locked").gameObject;
            Destroy(_locked);
        }
    }
}