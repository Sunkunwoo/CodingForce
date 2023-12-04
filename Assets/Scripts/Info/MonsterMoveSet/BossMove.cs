using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    public float moveSpeed;
    public Vector3 originalPosition; // ���� ��ǥ
    public Vector3 targetPosition;   // Ư�� ��ǥ
    private bool movingToTarget = true;

    void Start()
    {
        moveSpeed=GetComponent<Info>().MoveSpeed;
        // �ʱ� ��ǥ�� Ư�� ��ǥ�� ����
        targetPosition = new Vector3(9f, 5f, 0f);
        originalPosition = new Vector3(-9f, 5f, 0f);
    }

    void Update()
    {
        // ���� ��ǥ���� ��ǥ ��ǥ�� �ε巴�� �̵�
        MoveObject();
    }

    void MoveObject()
    {
        // Ư�� ��ǥ�� �̵� ���̸�
        if (movingToTarget)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            // Ư�� ��ǥ�� �����ϸ� ���� ��ǥ�� �̵��� ������ ǥ��
            if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
            {
                movingToTarget = false;
            }
        }
        // ���� ��ǥ�� �̵� ���̸�
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, originalPosition, moveSpeed * Time.deltaTime);

            // ���� ��ǥ�� �����ϸ� Ư�� ��ǥ�� �̵��� ������ ǥ��
            if (Vector3.Distance(transform.position, originalPosition) < 0.1f)
            {
                movingToTarget = true;
            }
        }
    }
}
