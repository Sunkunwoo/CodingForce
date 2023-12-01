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
        SceneManager.sceneLoaded += OnSceneLoaded; //다른 씬으로 넘어갈때 쓰이는 sceneLoaded가 호추될때 OnSceneLoaded도 호출 
        gameObject.SetActive(false);
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if(scene.name == "Lobby" || scene.name == "Ending") // 플레이어 오브젝트가 안보이게 하고싶은 씬의 이름을 추가해야합니다.
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }    
    }



}
