using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizingObject : MonoBehaviour
{
    public float minXSize = 1.6f; // 초기 x 크기
    public float maxXSize = 16f; // 최대 x 크기
    public float minYSize = 0.9f; // 초기 y 크기
    public float maxYSize = 9f; // 최대 y 크기
    public float initialResizeSpeed = 1f; // 초기 크기 조절 속도
    public float accelerationRate = 6f; // 크기 조절 속도의 가속도

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

        // 초기 색상 설정
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

                // 랜덤한 다음 색상 설정
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

                // 랜덤한 다음 색상 설정
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
