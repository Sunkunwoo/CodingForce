using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public AudioClip trickatkSound;
    public GameObject Bullet;
    public Transform spawnPoint;
    public float atkValue;
    public void EnableScript(bool enable)
    {
        enabled = enable;

        if (!enable)
        {
            // 스크립트를 비활성화할 때 InvokeRepeating도 중지
            CancelInvoke("ShootWithAtk");
        }
        else
        {
            float interval = 1f / GetComponent<Info>().BulletRpm;
            InvokeRepeating("ShootWithAtk", 0f, interval);
        }
    }
    private void Start()
    {
        float interval = 1f / GetComponent<Info>().BulletRpm;
        trickatkSound = GetComponent<Info>().atkSound;
        InvokeRepeating("ShootWithAtk", 0f, interval);
    }
    private void ShootWithAtk()
    {
        atkValue = GetComponent<Info>().Atk;
        Shoot(atkValue);
    }
    public void Shoot(float atk)
    {
        SoundManager.s.PlayFXSound(trickatkSound);
        if (Bullet != null && spawnPoint != null)
        {
            GameObject bullet = Instantiate(Bullet, spawnPoint.position, spawnPoint.rotation);

            PlayerBulletController bulletController = bullet.GetComponent<PlayerBulletController>();
            if (bulletController != null)
            {
                bulletController.Initialize(atk);
            }
        }
    }
}
