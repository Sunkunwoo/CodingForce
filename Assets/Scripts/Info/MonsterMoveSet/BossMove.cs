using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    private float moveSpeed;
    private Vector3 positionA; // Ư�� ��ǥA
    private Vector3 positionB;   // Ư�� ��ǥ
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
        // ���� ��ǥ���� ��ǥ ��ǥ�� �ε巴�� �̵�
        MoveObject();
    }

    protected virtual void MoveObject()
    {
    }
}
