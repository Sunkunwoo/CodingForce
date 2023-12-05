using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShoot : ShootManager
{
    protected override void Start()
    {
        Speed = 3f;
        trickatkSound = GetComponent<Info>().atkSound;
        InvokeRepeating("Shoot", 0f, 0.5f);
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
