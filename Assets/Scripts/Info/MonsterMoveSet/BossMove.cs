using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    public float moveSpeed;
    public Vector3 originalPosition; // 원래 좌표
    public Vector3 targetPosition;   // 특정 좌표
    private bool movingToTarget = true;

    void Start()
    {
        moveSpeed=GetComponent<Info>().MoveSpeed;
        // 초기 목표를 특정 좌표로 설정
        targetPosition = new Vector3(9f, 5f, 0f);
        originalPosition = new Vector3(-9f, 5f, 0f);
    }

    void Update()
    {
        // 현재 좌표에서 목표 좌표로 부드럽게 이동
        MoveObject();
    }

    void MoveObject()
    {
        // 특정 좌표로 이동 중이면
        if (movingToTarget)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            // 특정 좌표에 도착하면 원래 좌표로 이동할 것임을 표시
            if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
            {
                movingToTarget = false;
            }
        }
        // 원래 좌표로 이동 중이면
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, originalPosition, moveSpeed * Time.deltaTime);

            // 원래 좌표에 도착하면 특정 좌표로 이동할 것임을 표시
            if (Vector3.Distance(transform.position, originalPosition) < 0.1f)
            {
                movingToTarget = true;
            }
        }
    }
}
