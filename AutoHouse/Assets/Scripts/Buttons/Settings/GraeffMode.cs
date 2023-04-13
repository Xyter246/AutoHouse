using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraeffMode : GameManager
{
    public void BoolGraeffMode(bool GraeffModeEnabled)
    {
        GRAEFF_MODE = GraeffModeEnabled;
    }

    private void Awake()
    {
        GRAEFF_MODE = false;
    }
}
