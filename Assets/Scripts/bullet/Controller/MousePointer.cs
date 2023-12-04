using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePointer : MonoBehaviour
{
    void Update()
    {
        // ���� ���콺 ��ġ�� ��������
        Vector3 mousePosition = Input.mousePosition;

        // ī�޶󿡼��� ���콺 ��ġ�� ��ȯ
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // ���콺 �����͸� ���콺 ��ġ�� �̵�
        transform.position = new Vector3(mousePosition.x, mousePosition.y, 0);
    }
}
