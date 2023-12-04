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
            MoveSpeed = 500;
            BulletRpm = 2;
            Character = CharacterType.Player;
        }
        else
        {
            MaxHp = 999999;
            Hp = 999999;
            Atk = 100000;
            MoveSpeed = 500;
            BulletRpm = 300;
            Character = CharacterType.Player;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    private void OnDestroy()
    {
        if (deadSound != null)
        {
            SoundManager.s.PlayFXSound(deadSound);
        }
        else
        {
            Debug.Log("deadSound File is null");
        }

        GameManager.I.GameOver();
    }
}
