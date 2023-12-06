using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizingObject : MonoBehaviour
{
    public float minXSize = 1.6f; // �ʱ� x ũ��
    public float maxXSize = 16f; // �ִ� x ũ��
    public float minYSize = 0.9f; // �ʱ� y ũ��
    public float maxYSize = 9f; // �ִ� y ũ��
    public float initialResizeSpeed = 1f; // �ʱ� ũ�� ���� �ӵ�
    public float accelerationRate = 6f; // ũ�� ���� �ӵ��� ���ӵ�

    private float xResizeSpeed;
    private float yResizeSpeed;
    private bool isGrowing = true;

    private float originalXSize;
    private float originalYSize;

    void Start()
    {
        originalXSize = transform.localScale.x;
        originalYSize = transform.localScale.y;

        xResizeSpeed = initialResizeSpeed;
        yResizeSpeed = initialResizeSpeed;

        // �ʱ� ���� ����
        SetRandomColor();
    }

    void Update()
    {
        float newXSize = transform.localScale.x;
        float newYSize = transform.localScale.y;

        if (isGrowing)
        {
            newXSize += xResizeSpeed * Time.deltaTime;
            newYSize += yResizeSpeed * Time.deltaTime;

            xResizeSpeed += accelerationRate * Time.deltaTime;
            yResizeSpeed += accelerationRate * Time.deltaTime;

            if (newXSize >= maxXSize || newYSize >= maxYSize)
            {
                newXSize = minXSize;
                newYSize = minYSize;

                xResizeSpeed = initialResizeSpeed;
                yResizeSpeed = initialResizeSpeed;

                // ������ ���� ���� ����
                SetRandomColor();
            }
        }
        else
        {
            newXSize -= xResizeSpeed * Time.deltaTime;
            newYSize -= yResizeSpeed * Time.deltaTime;

            if (newXSize <= minXSize || newYSize <= minYSize)
            {
                newXSize = originalXSize;
                newYSize = originalYSize;

                xResizeSpeed = initialResizeSpeed;
                yResizeSpeed = initialResizeSpeed;

                // ������ ���� ���� ����
                SetRandomColor();
            }
        }

        transform.localScale = new Vector3(newXSize, newYSize, transform.localScale.z);
    }

    void SetRandomColor()
    {
        Renderer renderer = GetComponent<Renderer>();

        if (renderer != null)
        {
            Color randomColor = new Color(Random.value, Random.value, Random.value);
            renderer.material.color = randomColor;
        }
    }
}
