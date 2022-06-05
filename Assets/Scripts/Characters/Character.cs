using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Character : NetworkBehaviour
{
    [SerializeField] protected CharacterMovement characterMovement;

    private void Awake()
    {
        Setup();
    }

    public void Setup()
    {
        characterMovement = new CharacterMovement(this, 7f);
    }
}
