using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public AudioClip trickatkSound;
    public GameObject Bullet;
    public Transform spawnPoint;
    public float atkValue;
    private void Start()
    {
        trickatkSound = GetComponent<Info>().atkSound;
        InvokeRepeating("ShootWithAtk", 0f, 0.5f);
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
            // 탄알 스크립트 가져오기
            PlayerBulletController bulletController = bullet.GetComponent<PlayerBulletController>();
            if (bulletController != null)
            {
                // Atk 값을 전달하여 탄알 초기화
                bulletController.Initialize(atk);
            }
        }
    }
}
