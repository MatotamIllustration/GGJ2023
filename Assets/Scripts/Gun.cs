using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    //shoot the bullets from here
    public Transform barrel;
    // Start is called before the first frame update
    void Awake()
    {
        InputManager.AddActionToInput(InputDistributor.inputActions.Player.Shoot, Shoot);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot(InputAction.CallbackContext context)
    {
        Instantiate(bulletPrefab, barrel.transform.position, new Quaternion(0, 0, 0, 0));
    }

}
