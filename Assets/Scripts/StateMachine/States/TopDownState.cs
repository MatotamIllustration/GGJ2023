using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownState : Gamestate
{
    bool toGunGrid;
    public TopDownState()
    {
        transitions = new List<StateTransition>();

        transitions.Add(new StateTransition(typeof(GunGridState), () => toGunGrid == true));
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
        InputManager.ClearAllActionsFromInput(InputDistributor.inputActions.Player.Shoot);
    }
}
