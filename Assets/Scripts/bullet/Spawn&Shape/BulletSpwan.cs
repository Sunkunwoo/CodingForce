using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpwan : MonoBehaviour
{
    float atk;
    float rpm;
    AudioClip atkSound;
    // Start is called before the first frame update
    void Start()
    {
        atk = GetComponent<Info>().Atk;
        rpm = GetComponent<Info>().BulletRpm;
        atkSound = GetComponent<Info>().atkSound;
        StartCoroutine(ShootProjectiles());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ShootProjectiles()
    {
        while (true)
        {
            SpawnBullet();
            yield return new WaitForSeconds(60f / rpm);
        }
    }
    void SpawnBullet()
    {
        // ���Ͱ� ź���� �߻��ϴ� ��ũ��Ʈ ��������
        ShootManager bulletSpawner = GetComponent<ShootManager>();
        if (bulletSpawner != null)
        {
            // Atk ���� �����Ͽ� ź�� �߻�
            bulletSpawner.Shoot(atk);
            SoundManager.s.PlayFXSound(atkSound);
        }
    }
}
