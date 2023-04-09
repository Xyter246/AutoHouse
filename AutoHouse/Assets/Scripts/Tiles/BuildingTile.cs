using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingTile : Tile
{
    private int _amountCoal;
    public int AmountCoal {
        get { return _amountCoal; }
        set { _amountCoal = value; }
    }

    private int _amountCopper;
    public int AmountCopper {
        get { return _amountCopper; }
        set { _amountCopper = value; }
    }

    private int _amountGold;
    public int AmountGold {
        get { return _amountGold; }
        set { _amountGold = value; }
    }

    private int _amountIron;
    public int AmountIron {
        get { return _amountIron; }
        set { _amountIron = value; }
    }

    private int _amountStone;
    public int AmountStone
    {
        get { return _amountStone; }
        set { _amountStone = value; }
    }

    private int _amountWood;
    public int AmountWood
    {
        get { return _amountWood; }
        set { _amountWood = value; }
    }

    private int _amountCircuitBoards;
    public int AmountCircuitBoards
    {
        get { return _amountCircuitBoards; }
        set { _amountCircuitBoards = value; }
    }
}
