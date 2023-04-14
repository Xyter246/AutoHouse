using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorButton : GameManager
{
    public void OnClick()
    {
        // If button is clicked, select nothing
        SelectedBuildingType = null;
    }
}
