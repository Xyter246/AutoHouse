using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryGUI : GameManager
{
    [SerializeField] private TextMeshProUGUI _woodAmountTXT;
    [SerializeField] private TextMeshProUGUI _woodAmountTXT2;
    [SerializeField] private TextMeshProUGUI _stoneAmountTXT;
    [SerializeField] private TextMeshProUGUI _stoneAmountTXT2;
    [SerializeField] private TextMeshProUGUI _coalAmountTXT;
    [SerializeField] private TextMeshProUGUI _coalAmountTXT2;
    [SerializeField] private TextMeshProUGUI _copperAmountTXT;
    [SerializeField] private TextMeshProUGUI _copperAmountTXT2;
    [SerializeField] private TextMeshProUGUI _ironAmountTXT;
    [SerializeField] private TextMeshProUGUI _ironAmountTXT2;
    [SerializeField] private TextMeshProUGUI _goldAmountTXT;
    [SerializeField] private TextMeshProUGUI _goldAmountTXT2;

    private void Update()
    {
        if (NEW_INVENTORY_MODE) {
            _woodAmountTXT2.text = "Wood: " + AMOUNT_WOOD.ToString();
            _stoneAmountTXT2.text = "Stone: " + AMOUNT_STONE.ToString();
            _coalAmountTXT2.text = "Coal: " + AMOUNT_COAL.ToString();
            _copperAmountTXT2.text = "Copper: " + AMOUNT_COPPER.ToString();
            _ironAmountTXT2.text = "Iron: " + AMOUNT_IRON.ToString();
            _goldAmountTXT2.text = "Gold: " + AMOUNT_GOLD.ToString();
        } else {
            _woodAmountTXT.text = "Wood: " + AMOUNT_WOOD.ToString();
            _stoneAmountTXT.text = "Stone: " + AMOUNT_STONE.ToString();
            _coalAmountTXT.text = "Coal: " + AMOUNT_COAL.ToString();
            _copperAmountTXT.text = "Copper: " + AMOUNT_COPPER.ToString();
            _ironAmountTXT.text = "Iron: " + AMOUNT_IRON.ToString();
            _goldAmountTXT.text = "Gold: " + AMOUNT_GOLD.ToString();
        }
    }
}