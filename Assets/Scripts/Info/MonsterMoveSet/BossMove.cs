using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    protected float moveSpeed;
    protected Vector3 positionA; // Ư�� ��ǥA
    protected Vector3 positionB;   // Ư�� ��ǥ
    protected bool movingToTarget = true;

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
