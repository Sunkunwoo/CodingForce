using UnityEngine;


public class CircleShoot : ShootManager
{
    private const int DegreesPerIteration = 15;

    public override void Shoot(float atk)
    {
        SoundManager.s.PlayFXSound(trickatkSound);

        if (Bullet != null && spawnPoint != null)
        {
            for (int i = 0; i < 360; i += DegreesPerIteration)
            {
                SpawnBullet(spawnPoint.position, Quaternion.Euler(0, 0, i), atk, Speed);
            }
        }
    }
}