using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightShoot : ShootManager
{
    public override void Shoot(float atk)
    {
        SoundManager.s.PlayFXSound(trickatkSound);
        if (Bullet != null && spawnPoint != null)
        {
            SpawnBullet(spawnPoint.position, spawnPoint.rotation, atk);
        }
    }
}
