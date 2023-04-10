using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryGUI : GameManager
{
    [SerializeField] private GameObject _coalInventory;
    [SerializeField] private Text _coalAmountTXT;
    [SerializeField] private Text _copperAmountTXT;
    [SerializeField] private Text _goldAmountTXT;
    [SerializeField] private Text _ironAmountTXT;
    [SerializeField] private Text _stoneAmountTXT;
    [SerializeField] private Text _woodAmountTXT;

    private void Start()
    {
    //    _coalAmountTXT = _coalInventory.GetComponent<TextMeshPro>();   
    }

    private void OnEnable()
    {
    //    _coalAmountTXT = "Coal: " + AMOUNT_COAL.ToString();
        _copperAmountTXT.text = "Copper: " + AMOUNT_COPPER.ToString();
        _goldAmountTXT.text = "Gold: " + AMOUNT_GOLD.ToString();
        _ironAmountTXT.text = "Iron: " + AMOUNT_IRON.ToString();
        _stoneAmountTXT.text = "Stone: " + AMOUNT_STONE.ToString();
        _woodAmountTXT.text = "Wood: " + AMOUNT_WOOD.ToString();
    }
}
