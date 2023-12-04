using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightShoot : ShootManager
{
    protected override void Start()
    {
        Speed = 3f;
        trickatkSound = GetComponent<Info>().atkSound;
        InvokeRepeating("Shoot", 0f, 1f);
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
