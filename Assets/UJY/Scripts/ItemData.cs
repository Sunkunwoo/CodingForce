using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using static Info;

public class ItemData : Info
{
    public AudioClip ItemSound;
    public ItemType itype;
    public enum ItemType
    {
        Apple,
        Banana,
        Kiwi,
        Pineapple,
        Mellon
    }

    void Start()
    {
        SetItemStats();
    }

    void SetItemStats()
    {
        switch (itype)
        {
            case ItemType.Apple:
                Hp = 10;
                Atk = 0;
                MoveSpeed = 0;
                BulletRpm = 0;
                break;
            case ItemType.Banana:
                Hp = 0;
                Atk = 0;
                MoveSpeed = 1;
                BulletRpm = 0;
                break;
            case ItemType.Kiwi:
                Hp = 0;
                Atk = 0;
                MoveSpeed = 0;
                BulletRpm = 10;
                break;
            case ItemType.Pineapple:
                Hp = -10;
                Atk = -1;
                MoveSpeed = -1;
                BulletRpm = -10;
                break;
            case ItemType.Mellon:
                Hp = 0;
                Atk = 10;
                MoveSpeed = 0;
                BulletRpm = 0;
                break;

        }
    }
}
