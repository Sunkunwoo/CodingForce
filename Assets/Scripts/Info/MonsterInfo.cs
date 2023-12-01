using System.Collections;
using UnityEngine;

public class MonsterInfo : Info
{
    public CharacterType type;

    void Start()
    {
        float x = Random.Range(-8.5f, 8f);
        float y = 5;
        transform.position = new Vector3(x, y, 0);
        SetMonsterStats();
        StartCoroutine(ShootProjectiles());
    }

    void SetMonsterStats()
    {
        switch (type)
        {
            case CharacterType.Monster1:
                MaxHp = 20;
                Hp = MaxHp;
                Atk = 10;
                MoveSpeed = 2;
                BulletRpm = 60;
                break;
            case CharacterType.Monster2:
                MaxHp = 50;
                Hp = MaxHp;
                Atk = 3;
                MoveSpeed = 1;
                BulletRpm = 120;
                break;
            case CharacterType.Monster3:
                MaxHp = 10;
                Hp = MaxHp;
                Atk = 20;
                MoveSpeed = 4;
                BulletRpm = 20;
                break;
            case CharacterType.Monster4:
                MaxHp = 10;
                Hp = MaxHp;
                Atk = 1;
                MoveSpeed = 1;
                BulletRpm = 60;
                break;
            case CharacterType.Monster5:
                MaxHp = 100;
                Hp = MaxHp;
                Atk = 15;
                MoveSpeed = 2;
                BulletRpm = 60;
                break;
            case CharacterType.Boss1:
                MaxHp = 200;
                Hp = MaxHp;
                Atk = 10;
                MoveSpeed = 5;
                BulletRpm = 120;
                break;
            case CharacterType.Boss2:
                MaxHp = 250;
                Hp = MaxHp;
                Atk = 15;
                MoveSpeed = 5;
                BulletRpm = 120;
                break;
            case CharacterType.Boss3:
                MaxHp = 300;
                Hp = MaxHp;
                Atk = 20;
                MoveSpeed = 5;
                BulletRpm = 120;
                break;
        }
    }

    IEnumerator ShootProjectiles()
    {
        while (true)
        {
            SpawnBullet();
            yield return new WaitForSeconds(60f/BulletRpm);
        }
    }

    void SpawnBullet()
    {
        // 몬스터가 탄알을 발사하는 스크립트 가져오기
        BulletSpawner bulletSpawner= GetComponent<BulletSpawner>();

        if (bulletSpawner != null)
        {
            // Atk 값을 전달하여 탄알 발사
            bulletSpawner.SpawnBullet(Atk);
            SoundManager.s.PlayFXSound(atkSound);
        }
    }

}
