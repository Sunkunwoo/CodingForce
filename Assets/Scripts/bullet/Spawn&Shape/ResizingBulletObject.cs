using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizingBulletObject : MonoBehaviour
{
    public float speed = 5f;  // 총알 이동 속도
    public float maxSize = 1.0f;  // 총알의 최대 크기
    public float minSize = 0.1f;  // 총알의 최소 크기
    public float shrinkSpeed = 0.1f;  // 총알 크기 감소 속도

    private Vector3 targetPosition;

    void Start()
    {
        // B 좌표를 설정하거나 원하는 대상의 위치를 지정합니다.
        targetPosition = new Vector3(10f, 0f, 0f);
    }

    void Update()
    {
        // 총알을 B 좌표로 이동시킵니다.
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // 총알 크기를 줄입니다.
        transform.localScale = Vector3.Lerp(transform.localScale, Vector3.one * minSize, shrinkSpeed * Time.deltaTime);

        // 총알이 B 좌표에 도달하면 파괴합니다.
        if (transform.position == targetPosition)
        {
            Destroy(gameObject);
        }
    }
}
