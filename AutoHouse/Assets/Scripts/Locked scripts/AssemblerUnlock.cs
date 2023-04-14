using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssemblerUnlock : GameManager
{
    [SerializeField] private GameObject _assemblerButton;
    [SerializeField] private GameObject _assemblerUnlock;
    [SerializeField] private GameObject _storyEndGUI;
    private GameObject _locked;

    public void OnClick()
    {
        // If UNLOCK gets clicked on Assembler research, and there are enough resources
        if (AMOUNT_COPPER >= 55 && AMOUNT_IRON >= 75 && AMOUNT_GOLD >= 20) {
            AMOUNT_COPPER -= 55;
            AMOUNT_IRON -= 75;
            AMOUNT_GOLD -= 20;

            // Disable every thing that hides assembler...
            _assemblerUnlock.SetActive(false); // can Destroy, because it will never be needed again in the same game

            // Actually remove the Lock
            _locked = _assemblerButton.transform.Find("Locked").gameObject;
            Destroy(_locked);

            // Open up the last GUI for the "story"...
            _storyEndGUI.SetActive(true);
        }
    }
}