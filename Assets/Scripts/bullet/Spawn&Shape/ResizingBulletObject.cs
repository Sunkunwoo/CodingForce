using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizingBulletObject : MonoBehaviour
{
    public float speed = 5f;  // �Ѿ� �̵� �ӵ�
    public float maxSize = 1.0f;  // �Ѿ��� �ִ� ũ��
    public float minSize = 0.1f;  // �Ѿ��� �ּ� ũ��
    public float shrinkSpeed = 0.1f;  // �Ѿ� ũ�� ���� �ӵ�

    private Vector3 targetPosition;

    void Start()
    {
        // B ��ǥ�� �����ϰų� ���ϴ� ����� ��ġ�� �����մϴ�.
        targetPosition = new Vector3(10f, 0f, 0f);
    }

    void Update()
    {
        // �Ѿ��� B ��ǥ�� �̵���ŵ�ϴ�.
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // �Ѿ� ũ�⸦ ���Դϴ�.
        transform.localScale = Vector3.Lerp(transform.localScale, Vector3.one * minSize, shrinkSpeed * Time.deltaTime);

        // �Ѿ��� B ��ǥ�� �����ϸ� �ı��մϴ�.
        if (transform.position == targetPosition)
        {
            Destroy(gameObject);
        }
    }
}
