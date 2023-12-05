using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MousePointer : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = false;
        DontDestroyOnLoad(this.gameObject);
        SceneManager.sceneLoaded += PointerDestory;
    }

    void Update()
    {
        // ���� ���콺 ��ġ�� ��������
        Vector3 mousePosition = Input.mousePosition;

        // ī�޶󿡼��� ���콺 ��ġ�� ��ȯ
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // ���콺 �����͸� ���콺 ��ġ�� �̵�
        transform.position = new Vector3(mousePosition.x, mousePosition.y, 0);
    }

    void PointerDestory(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Title")
        {
            Destroy(gameObject);
        }
    }
}
