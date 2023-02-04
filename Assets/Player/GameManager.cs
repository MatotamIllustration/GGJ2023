using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    GameStateMachine stateMachine;

    private void Awake()
    {
        //stateMachine = new GameStateMachine()
        GunManager.Initialize();
    }
}
