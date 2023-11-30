using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMove : CharacterController
{
    public void OnMovePlayer(InputValue input)
    {
        Vector2 moveInput = input.Get<Vector2>().normalized;
        InvokeMoveEvent(moveInput);
    }
}
