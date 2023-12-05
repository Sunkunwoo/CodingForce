using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAim : MonoBehaviour
{
    [SerializeField] private Transform Aim;
    [SerializeField] private Transform playerTransform;

    void Update()
    {
        // �÷��̾��� ��ġ�� �������� ���콺�� ��ũ�� ��ǥ�� ���� ��ǥ�� ��ȯ
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, playerTransform.position.z));

        // �÷��̾��� �������� ȸ��
        RotateArm(mousePos - playerTransform.position);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        Aim.rotation = Quaternion.Euler(0, 0, rotZ-90);
    }
}
