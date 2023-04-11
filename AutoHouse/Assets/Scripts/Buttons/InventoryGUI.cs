using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryGUI : GameManager
{
    [SerializeField] private TextMeshProUGUI _coalAmountTXT;
    [SerializeField] private TextMeshProUGUI _copperAmountTXT;
    [SerializeField] private TextMeshProUGUI _goldAmountTXT;
    [SerializeField] private TextMeshProUGUI _ironAmountTXT;
    [SerializeField] private TextMeshProUGUI _stoneAmountTXT;
    [SerializeField] private TextMeshProUGUI _woodAmountTXT;

    private void Update()
    {
        _coalAmountTXT.text = "Coal: " + AMOUNT_COAL.ToString();
        _copperAmountTXT.text = "Copper: " + AMOUNT_COPPER.ToString();
        _goldAmountTXT.text = "Gold: " + AMOUNT_GOLD.ToString();
        _ironAmountTXT.text = "Iron: " + AMOUNT_IRON.ToString();
        _stoneAmountTXT.text = "Stone: " + AMOUNT_STONE.ToString();
        _woodAmountTXT.text = "Wood: " + AMOUNT_WOOD.ToString();
    }
}
