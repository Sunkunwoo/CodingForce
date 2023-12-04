using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    private float moveSpeed;
    private Vector3 positionA; // 특정 좌표A
    private Vector3 positionB;   // 특정 좌표
    private bool movingToTarget = true;

    public Vector3 PositionA
    {
        get { return positionA; }
        set { positionA = value; }
    }

    public Vector3 PositionB
    {
        get { return positionB; }
        set { positionB = value; }
    }

    public bool MovingToTarget
    {
        get { return movingToTarget; }
        set { movingToTarget = value; }
    }

    public float MoveSpeed
    {
        get { return moveSpeed; }
    }

    protected virtual void Start()
    {
        moveSpeed = GetComponent<Info>().MoveSpeed;
    }

    protected virtual void Update()
    {
        // 현재 좌표에서 목표 좌표로 부드럽게 이동
        MoveObject();
    }

    protected virtual void MoveObject()
    {
    }
}
