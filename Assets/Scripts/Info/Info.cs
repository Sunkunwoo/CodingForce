using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour
{
    public enum CharacterType
    {
        Player,
        Monster,
        Boss,
    }

    private float maxHp;
    private float hp;
    private float atk;
    private float moveSpeed;
    private float bulletRpm;
    private CharacterType character;

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
    public CharacterType Character
    {
        get { return character; }
        set { character = value; }
    }

    public event Action OnDeath;
    public void DamageResult(float damage)
    {
        Hp -= damage;

        if (Hp <= 0)
        {
            if (Character == CharacterType.Player)
            {
                GameManager.I.GameOver();
            }
            else
            {
                OnDeath?.Invoke();
                Destroy(gameObject);
            }
        }
    }
}
