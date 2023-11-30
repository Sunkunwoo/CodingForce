using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInfo : Info
{
    // Start is called before the first frame update
    void Start()
    {
        MaxHp = 100;
        Hp = 100;
        MoveSpeed = 5;
        BulletRpm = 2;

        DontDestroyOnLoad(this.gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded; //�ٸ� ������ �Ѿ�� ���̴� sceneLoaded�� ȣ�ߵɶ� OnSceneLoaded�� ȣ�� 
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if(scene.name == "Lobby" || scene.name == "Ending") // �÷��̾� ������Ʈ�� �Ⱥ��̰� �ϰ���� ���� �̸��� �߰��ؾ��մϴ�.
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }    
    }
}
