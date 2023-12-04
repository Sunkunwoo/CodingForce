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
        // 초기 목표를 A로 설정
        currentTarget = FindTarget(targetATag);
    }

    void Update()
    {
        // 현재 목표 방향으로 이동
        MoveObject();

        // 목표에 도달했는지 확인하고, 도달하면 목표를 교체
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
        // 현재 목표가 A면 B로, B면 A로 변경
        if (currentTarget.CompareTag(targetATag))
        {
            currentTarget = FindTarget(targetBTag);
        }
        else
        {
            currentTarget = FindTarget(targetATag);
        }

        // 이동 방향을 새로운 목표로 설정
        transform.forward = (currentTarget.position - transform.position).normalized;
    }

    Transform FindTarget(string tag)
    {
        // 주어진 태그를 가진 GameObject를 찾아서 반환
        GameObject targetObject = GameObject.FindGameObjectWithTag(tag);
        return targetObject != null ? targetObject.transform : null;
    }
}
