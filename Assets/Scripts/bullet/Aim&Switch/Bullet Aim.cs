using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAim : MonoBehaviour
{
    [SerializeField] private Transform Aim;
    [SerializeField] private Transform playerTransform;

    void Update()
    {
        // 플레이어의 위치를 기준으로 마우스의 스크린 좌표를 월드 좌표로 변환
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, playerTransform.position.z));

        // 플레이어의 방향으로 회전
        RotateArm(mousePos - playerTransform.position);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        Aim.rotation = Quaternion.Euler(0, 0, rotZ-90);
    }
}
