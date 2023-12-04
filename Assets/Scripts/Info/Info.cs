using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour
{
    public AudioClip atkSound;
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

    public GameObject particlePrefab; // 파티클 프리팹을 Inspector에서 설정

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
                GameObject particleEffect = Instantiate(particlePrefab, transform.position, Quaternion.identity);
                Destroy(gameObject);
                //GameManager.I.GameOver();
            }
            else
            {
                GameManager.I.killCount++;
                GameManager.I.SpwanCount--;
                OnDeath?.Invoke();
                Destroy(gameObject);
            }
        }
    }
    public void GetItem(int type)
    {
        if (type == 1)
        {
            Debug.Log("체력 up");
            Hp += 20;
            Debug.Log(Hp);

        }

        if (type == 2)
        {
            Debug.Log("공격력 up");
            Atk += 5;
            Debug.Log(Atk);
        }

        if (type == 3)
        {
            Debug.Log("속도 up");
            BulletRpm += 20;
            MoveSpeed += 5;
            Debug.Log(BulletRpm);
            Debug.Log(MoveSpeed);
        }
        if (type == 4)
        { 
            Debug.Log("총알 + 몬스터 삭제");
            GameObject[] mbullet = GameObject.FindGameObjectsWithTag("Mbullet");
            GameObject[] monster = GameObject.FindGameObjectsWithTag("Monster");

            for (int i = 0; i < mbullet.Length; i++)
            {
                Destroy(mbullet[i]);
            }

            for (int i = 0; i < monster.Length; i++)
            {
                Destroy(monster[i]);
            }
        }

        if (type == 5)
        {
            Debug.Log("5초간 쉴드 생성");
            GameObject shield = transform.GetChild(0).gameObject;
            shield.SetActive(true);
            Invoke("ShieldOff", 5f);
        }

    }

    public void ShieldOff()
    {
        GameObject shield = transform.GetChild(0).gameObject;
        shield.SetActive(false);
    }


}
