using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private float moveSpeed;
    private CharacterController controller;
    private Vector2 moveDirection = Vector2.zero;
    private Rigidbody2D rigidbody;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        moveSpeed = GetComponent<Info>().MoveSpeed;
        ApplyMovement(moveDirection);
    }

    private void Move(Vector2 direction)
    {
        moveDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * moveSpeed * Time.deltaTime;
        rigidbody.velocity = direction;
    }
}
