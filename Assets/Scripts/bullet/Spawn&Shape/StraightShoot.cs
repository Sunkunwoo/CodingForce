using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightShoot : ShootManager
{
    float rpm;
    protected override void Start()
    {
        rpm = GetComponent<Info>().BulletRpm;
        Speed = 3f;
        trickatkSound = GetComponent<Info>().atkSound;
        InvokeRepeating("Shoot", 0f, rpm);
    }
    public override void Shoot(float atk)
    {
        SoundManager.s.PlayFXSound(trickatkSound);
        if (Bullet != null && spawnPoint != null)
        {
            SpawnBullet(spawnPoint.position, spawnPoint.rotation, atk, Speed);
        }
    }
}
