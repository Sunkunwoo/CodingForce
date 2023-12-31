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
        // 현재 마우스 위치를 가져오기
        Vector3 mousePosition = Input.mousePosition;

        // 카메라에서의 마우스 위치로 변환
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // 마우스 포인터를 마우스 위치로 이동
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
