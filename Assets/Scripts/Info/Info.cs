using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour
{
    public AudioClip atkSound;
    public AudioClip deadSound;

    public GameObject Bullet;
    public enum CharacterType
    {
        Player,
        Monster1,
        Monster2,
        Monster3,
        Monster4,
        Monster5,
        Boss1,
        Boss2,
        Boss3,
    }

    private float maxHp;
    private float hp;
    private float atk;
    private float moveSpeed;
    private float bulletRpm;
    private CharacterType character;

    public GameObject particlePrefab; // ��ƼŬ �������� Inspector���� ����

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
                if (deadSound != null)
                {
                    SoundManager.s.PlayFXSound(deadSound);
                }
                else
                {
                    Debug.Log("Dead Sound Clip is Null");
                }
                GameObject particleEffect = Instantiate(particlePrefab, transform.position, Quaternion.identity);
                Destroy(gameObject);
                //GameManager.I.GameOver();
            }
            else
            {
                OnDeath?.Invoke();
                Destroy(gameObject);
            }
        }
    }
}
