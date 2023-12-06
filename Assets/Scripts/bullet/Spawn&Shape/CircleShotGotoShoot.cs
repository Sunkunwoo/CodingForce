using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;



public class CircleShotGotoShoot : ShootManager
{
    private const int DegreesPerIteration = 75;
    private Vector3 TargetPosition;

    public override void Shoot(float atk)
    {
        SoundManager.s.PlayFXSound(trickatkSound);

        if (Bullet != null && spawnPoint != null)
        {
            List<Transform> bullets = new List<Transform>();

            for (int i = 0; i < 360; i += DegreesPerIteration)
            {
                GameObject temp = Instantiate(Bullet);
                Destroy(temp, 2f);
                temp.transform.position = spawnPoint.position;
                temp.transform.rotation = Quaternion.Euler(0, 0, i);

                MonsterBulletController bulletController = temp.GetComponent<MonsterBulletController>();
                if (bulletController != null)
                {
                    bulletController.Initialize(atk);
                }

                bullets.Add(temp.transform);
            }

            StartCoroutine(BulletToTarget(bullets));
        }
    }

    private IEnumerator BulletToTarget(List<Transform> objects)
    {
        yield return new WaitForSeconds(0.5f);
        foreach (var obj in objects)
        {
            if (obj != null)
            {
                TargetPosition.x = UnityEngine.Random.Range(-8.8f, 8.8f);
                Vector3 targetDirection = TargetPosition - obj.position;
                float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;
                obj.rotation = Quaternion.Euler(0, 0, angle);
            }
        }

        objects.Clear();
    }
}

