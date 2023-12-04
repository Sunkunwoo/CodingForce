using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    public string targetATag = "BmoveTA";
    public string targetBTag = "BmoveTB";

    private Transform currentTarget;

    void Start()
    {
        // �ʱ� ��ǥ�� A�� ����
        currentTarget = FindTarget(targetATag);
    }

    void Update()
    {
        // ���� ��ǥ �������� �̵�
        MoveObject();

        // ��ǥ�� �����ߴ��� Ȯ���ϰ�, �����ϸ� ��ǥ�� ��ü
        if (Vector3.Distance(transform.position, currentTarget.position) < 0.1f)
        {
            SwitchTarget();
        }
    }

    void MoveObject()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    void SwitchTarget()
    {
        // ���� ��ǥ�� A�� B��, B�� A�� ����
        if (currentTarget.CompareTag(targetATag))
        {
            currentTarget = FindTarget(targetBTag);
        }
        else
        {
            currentTarget = FindTarget(targetATag);
        }

        // �̵� ������ ���ο� ��ǥ�� ����
        transform.forward = (currentTarget.position - transform.position).normalized;
    }

    Transform FindTarget(string tag)
    {
        // �־��� �±׸� ���� GameObject�� ã�Ƽ� ��ȯ
        GameObject targetObject = GameObject.FindGameObjectWithTag(tag);
        return targetObject != null ? targetObject.transform : null;
    }
}
