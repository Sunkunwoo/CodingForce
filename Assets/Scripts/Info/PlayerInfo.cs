using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInfo : Info
{
    void Start()
    {
        MaxHp = 100;
        Hp = 100;
        Atk = 10;
        MoveSpeed = 5;
        BulletRpm = 2;
        IsPlayer = true;

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
