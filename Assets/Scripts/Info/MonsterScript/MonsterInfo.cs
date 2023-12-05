using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterInfo : Info
{
    public CharacterType type;
    private int addScore;

    void Start()
    {
        float x = Random.Range(-8.5f, 8f);
        float y = 5;
        transform.position = new Vector3(x, y, 0);
        SetMonsterStats();
    }

    void SetMonsterStats()
    {
        switch (type)
        {
            case CharacterType.Monster1:
                MaxHp = 20;
                Hp = MaxHp;
                Atk = 10;
                MoveSpeed = 2;
                BulletRpm = 60;
                addScore = 10;
                break;
            case CharacterType.Monster2:
                MaxHp = 50;
                Hp = MaxHp;
                Atk = 3;
                MoveSpeed = 1;
                BulletRpm = 120;
                addScore = 20;
                break;
            case CharacterType.Monster3:
                MaxHp = 10;
                Hp = MaxHp;
                Atk = 20;
                MoveSpeed = 4;
                BulletRpm = 20;
                addScore = 30;
                break;
            case CharacterType.Monster4:
                MaxHp = 10;
                Hp = MaxHp;
                Atk = 1;
                MoveSpeed = 1;
                BulletRpm = 60;
                addScore = 30;
                break;
            case CharacterType.Monster5:
                MaxHp = 100;
                Hp = MaxHp;
                Atk = 15;
                MoveSpeed = 2;
                BulletRpm = 60;
                addScore = 30;
                break;
            case CharacterType.Boss1:
                MaxHp = 200;
                Hp = MaxHp;
                Atk = 10;
                MoveSpeed = 10;
                BulletRpm = 120;
                addScore = 100;
                break;
            case CharacterType.Boss2:
                MaxHp = 250;
                Hp = MaxHp;
                Atk = 15;
                MoveSpeed = 10;
                BulletRpm = 120;
                addScore = 200;
                break;
            case CharacterType.Boss3:
                MaxHp = 300;
                Hp = MaxHp;
                Atk = 20;
                MoveSpeed = 10;
                BulletRpm = 120;
                addScore = 300;
                break;
        }
    }

    private void OnDestroy()
    {
        if (deadSound != null)
        {
            SoundManager.s.PlayFXSound(deadSound);
        }
        else
        {
            Debug.Log("Dead Sound Clip is Null");
        }
        GameManager.I.sccore += addScore;
        GameManager.I.killCount++;
        GameManager.I.SpwanCount--;
        Debug.Log("killCount: " + GameManager.I.killCount);
        Debug.Log("SpwanCount: " + GameManager.I.SpwanCount);
        switch(type)
        {
            case CharacterType.Boss1:
                GameManager.I.clearCheck = true;
                GameManager.I.stage = 2;
                GameManager.I.bossCheck = false;
                break;
            case CharacterType.Boss2:
                GameManager.I.clearCheck = true;
                GameManager.I.stage = 3;
                GameManager.I.bossCheck = false;
                break;
            case CharacterType.Boss3:
                GameManager.I.clearCheck = true;
                GameManager.I.stage = 4;
                GameManager.I.bossCheck = false;
                break;
        }
    }

}
