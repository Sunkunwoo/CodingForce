//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class MonsterBulletSpwan : MonoBehaviour
//{
//    float
//    // Start is called before the first frame update
//    void Start()
//    {
//        StartCoroutine(ShootProjectiles());
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }

//    IEnumerator ShootProjectiles()
//    {
//        while (true)
//        {
//            SpawnBullet();
//            yield return new WaitForSeconds(60f / BulletRpm);
//        }
//    }


//    void SpawnBullet()
//    {
//        // ���Ͱ� ź���� �߻��ϴ� ��ũ��Ʈ ��������
//        ShootManager bulletSpawner = GetComponent<ShootManager>();
//        //List<ShootManager> shootList = new List<ShootManager>();
//        //shootList.Add(new CircleShoot());
//        //shootList.Add(new CircleShotGotoShoot());
//        //shootList.Add(new HeartShoot());
//        //shootList.Add(new ShapeShoot());
//        //shootList.Add(new SpinShoot());
//        //shootList.Add(new StraightShoot());
//        //shootList[0].Shoot(Atk);
//        if (bulletSpawner != null)
//        {
//            // Atk ���� �����Ͽ� ź�� �߻�
//            bulletSpawner.Shoot(Atk);
//            SoundManager.s.PlayFXSound(atkSound);
//        }
//    }
//}
