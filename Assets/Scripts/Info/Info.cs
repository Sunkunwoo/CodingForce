using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour
{
    private float maxHp;
    private float hp;
    private float moveSpeed;
    private float bulletRpm;

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
}
