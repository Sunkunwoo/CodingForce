using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInfo : Info
{
    void Start()
    {
        if (GameManager.I.isCheat == false)
        {
            MaxHp = 100;
            Hp = 100;
            Atk = 10;
            MoveSpeed = 5;
            BulletRpm = 2;
            Character = CharacterType.Player;
        }
        else
        {
            MaxHp = 999999;
            Hp = 999999;
            Atk = 100000;
            MoveSpeed = 50;
            BulletRpm = 300;
            Character = CharacterType.Player;
        }
        GameManager.I.PlayerPos = GetComponent<Transform>();
        DontDestroyOnLoad(this.gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded; //�ٸ� ������ �Ѿ�� ���̴� sceneLoaded�� ȣ�ߵɶ� OnSceneLoaded�� ȣ�� 
        gameObject.SetActive(false);
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
