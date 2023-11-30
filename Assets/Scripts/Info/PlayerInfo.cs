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
        SceneManager.sceneLoaded += OnSceneLoaded; //다른 씬으로 넘어갈때 쓰이는 sceneLoaded가 호추될때 OnSceneLoaded도 호출 
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
