using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Monster : Info
{
    public int ID { get; }
    public string Name { get; }
    public string Description{ get; }
    public int Money { get; }


    public Monster(int id, int maxHp, int hp,int atk, int moveSpeed, int money, bool isplayer)
    {
        ID = id; 
        MaxHp = maxHp;
        Hp = hp;
        Atk = atk;
        MoveSpeed = moveSpeed;
        Money = money;
        IsPlayer = isplayer;
    }

    void Start()
    {
        MaxHp = 100;
        Hp = 100;
        Atk = 10;
        MoveSpeed = 5;
        IsPlayer = true;   
    }



}
