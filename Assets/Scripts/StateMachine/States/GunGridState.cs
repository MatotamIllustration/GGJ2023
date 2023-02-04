using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunGridState : Gamestate
{
    bool toTopDown;
    public GunGridState()
    {
        transitions = new List<StateTransition>();

        transitions.Add(new StateTransition(typeof(TopDownState), () => toTopDown == true));
    }
}
