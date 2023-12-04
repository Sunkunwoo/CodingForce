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

            PlayerBulletController bulletController = bullet.GetComponent<PlayerBulletController>();
            if (bulletController != null)
            {
                bulletController.Initialize(atk);
            }
        }
    }
}
