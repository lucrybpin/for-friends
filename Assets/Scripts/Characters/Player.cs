using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Character
{

    PlayerInputActions playerInput;
    [SerializeField] Checkpoint lastCheckPoint;

    private Rigidbody rigidBody;

    public Checkpoint LastCheckPoint { get => lastCheckPoint; set => lastCheckPoint =  value ; }

    private void Awake()
    {
        base.Setup();
        playerInput = new PlayerInputActions();
        playerInput.standard.Enable();
        rigidBody = GetComponent<Rigidbody>();
        //List<Checkpoint> checkPoints = FindObjectsOfType<Checkpoint>();
    }

    private void Start()
    {
        if (isLocalPlayer)
        {
            FindObjectOfType<CameraFollow>().SetTarget(this.transform.GetChild(0));
        }
    }

    private void LateUpdate()
    {
        HandleInput();
    }

    private void HandleInput()
    {
        HandleMovementInput();
        HandleBreakInput();
    }

    private void HandleBreakInput()
    {
        float breakAmount = playerInput.standard.Break.ReadValue<float>();
        if (breakAmount > 0)
            characterMovement.Break();
    }

    private void HandleMovementInput()
    {
        Vector3 inputDirection = playerInput.standard.Movement.ReadValue<Vector2>();
        characterMovement.Move(inputDirection);        
    }

    public void Die()
    {
        rigidBody.velocity = Vector3.zero;
        transform.position = lastCheckPoint.Location.position;
    }

}
