using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletSpwan : MonoBehaviour
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
        //List<ShootManager> shootList = new List<ShootManager>();
        //shootList.Add(new CircleShoot());
        //shootList.Add(new CircleShotGotoShoot());
        //shootList.Add(new HeartShoot());
        //shootList.Add(new ShapeShoot());
        //shootList.Add(new SpinShoot());
        //shootList.Add(new StraightShoot());
        //shootList[0].Shoot(Atk);
        if (bulletSpawner != null)
        {
            // Atk ���� �����Ͽ� ź�� �߻�
            bulletSpawner.Shoot(atk);
            SoundManager.s.PlayFXSound(atkSound);
        }
    }
}
