using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraeffMode : GameManager
{
    public void BoolGraeffMode(bool GraeffModeEnabled)
    {
        // Determines if GRAEFFMODE should be enabled, this checks the checkbox
        GRAEFF_MODE = GraeffModeEnabled;
    }

    private void Awake()
    {
        // Start game off without GRAEFFMODE
        GRAEFF_MODE = false;
    }
}
