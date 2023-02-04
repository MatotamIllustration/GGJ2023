using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float moveSpeed;

    public Transform gun;

    public GameObject bulletPrefab;
    //shoot the bullets from here
    public Transform barrel;

    public float gunDistanceFromPlayer;

    PlayerInputActions controls;
    // Start is called before the first frame update
    void Awake()
    {
        controls = new PlayerInputActions();
        InputDistributor.inputActions = controls;
        InputManager.Initialize(
            new InputAction[]
            {
                controls.Player.Move,
                controls.Player.Shoot
            });

        //inputManager.AddActionToInput(InputDistributor.inputActions.Player.Move, Move);
        InputManager.AddActionToInput(InputDistributor.inputActions.Player.Shoot, Shoot);

    }

    private void OnEnable()
    {
        InputManager.WhenEnabled();
        InputManager.AddActionToInput(InputDistributor.inputActions.Player.Shoot, Shoot);

    }

    private void OnDisable()
    {
        InputManager.WhenDisabled();
        InputManager.RemoveActionFromInput(InputDistributor.inputActions.Player.Shoot, Shoot);
    }

    // Update is called once per frame
    void Update()
    {
        //we're moving the gameobject this script is on.
        Move();
        MoveGun(gun);

    }

    void Move()
    {
        Vector2 inputDirection = InputDistributor.inputActions.Player.Move.ReadValue<Vector2>();
        //Debug.Log(inputDirection);

        float Horizontal = inputDirection.x * moveSpeed * Time.deltaTime;
        float Vertical = inputDirection.y * moveSpeed * Time.deltaTime;

        transform.position += new Vector3(Horizontal, Vertical, 0);
    }

    void MoveGun(Transform _toMove)
    {
        Vector2 transformPosition2D = new Vector2(transform.position.x, transform.position.y);
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 directionToMouse = mousePosition - transformPosition2D;
        _toMove.position = transformPosition2D + directionToMouse.normalized * gunDistanceFromPlayer;
        _toMove.right = directionToMouse.normalized;
    }

    public void Shoot(InputAction.CallbackContext context)
    {
        BullletShootable newBullet = new BullletShootable();
        Vector2 transformPosition2D = new Vector2(transform.position.x, transform.position.y);
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 directionToMouse = mousePosition - transformPosition2D;
        newBullet.MakeBullet(barrel.transform.position, directionToMouse) ;
    }
}
