using System;
using UnityEngine;

[System.Serializable]
public class CharacterMovement
{
    [SerializeField] private Character character;
    [SerializeField] private Rigidbody rigidBody;
    [SerializeField] private float baseSpeed;

    public CharacterMovement(Character character, float baseSpeed)
    {
        this.character = character;
        this.baseSpeed = baseSpeed;
        rigidBody = character.GetComponent<Rigidbody>();
    }

    public void Move(Vector2 input)
    {
        Vector3 direction = new Vector3(input.x, 0, input.y);
        direction.Normalize();
        rigidBody.AddForce(direction * baseSpeed, ForceMode.Force);
    }

    internal void Break()
    {
        rigidBody.velocity = new Vector3(
            rigidBody.velocity.x * 0.95f, 
            rigidBody.velocity.y, 
            rigidBody.velocity.z * 0.95f);
    }
}
