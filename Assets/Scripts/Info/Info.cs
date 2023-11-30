using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour
{
    private float maxHp;
    private float hp;
    private float atk;
    private float moveSpeed;
    private float bulletRpm;
    private bool isPlayer=false;

    public float MaxHp
    {
        get { return maxHp; }
        set { maxHp = value; }
    }
    public float Hp
    {
        get { return hp; }
        set { hp = value; }
    }
    public float Atk
    {
        get { return atk; }
        set { atk = value; }
    }
    public float MoveSpeed
    {
        get { return moveSpeed; }
        set { moveSpeed = value; }
    }
    public float BulletRpm
    {
        get { return bulletRpm; }
        set { bulletRpm = value; }
    }
    public bool IsPlayer
    {
        get { return isPlayer; }
        set { isPlayer = value; }
    }
    public void DeamegeResult(float damage)
    {
        Hp -= damage;

        if (Hp <= 0)
        {
            if (IsPlayer == true)
            {
                GameManager.I.GameOver();
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
