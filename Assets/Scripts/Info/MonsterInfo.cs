using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterInfo : Info
{
    public CharacterType type;

    void Start()
    {
        SetMonsterStats();
    }
    void SetMonsterStats()
    {
        switch (type)
        {
            case CharacterType.Monster:
                MaxHp = 10;
                Hp = MaxHp;
                Atk = 5;
                MoveSpeed = 1;
                BulletRpm = 1;
                break;
            case CharacterType.Boss:
                MaxHp = 200;
                Hp = MaxHp;
                Atk = 10;
                MoveSpeed = 5;
                BulletRpm = 10;
                break;
        }
    }


}
