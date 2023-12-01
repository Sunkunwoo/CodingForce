using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMove : CharacterController
{
    public void OnMove(InputValue input)
    {
        Debug.Log("OnMove" + input.ToString());
        Vector2 moveInput = input.Get<Vector2>().normalized;
        InvokeMoveEvent(moveInput);
    }
}
