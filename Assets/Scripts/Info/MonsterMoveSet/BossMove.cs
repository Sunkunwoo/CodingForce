using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    protected float moveSpeed;
    protected Vector3 positionA; // 특정 좌표A
    protected Vector3 positionB;   // 특정 좌표
    protected bool movingToTarget = true;

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
