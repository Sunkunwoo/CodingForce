using System.Collections;
using UnityEngine;

public class MonsterInfo : Info
{
    public CharacterType type;

    void Start()
    {
        SetMonsterStats();
        StartCoroutine(ShootProjectiles());
        GameObject bgmPlayerBossObject = GameObject.FindGameObjectWithTag("BossBgm");
        if (bgmPlayerBossObject != null)
        {
            bgmPlayerBossObject.SetActive(true);
        }
        else
        {
            Debug.LogWarning("No GameObject with the tag 'BgmPlayerBoss' found.");
        }
    }

    void SetMonsterStats()
    {
        switch (type)
        {
            case CharacterType.Monster:
                MaxHp = 10;
                Hp = MaxHp;
                Atk = 5;
                MoveSpeed = 1;
                BulletRpm = 60;
                break;
            case CharacterType.Boss:
                MaxHp = 200;
                Hp = MaxHp;
                Atk = 10;
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
        // ���Ͱ� ź���� �߻��ϴ� ��ũ��Ʈ ��������
        BulletSpawner bulletSpawner= GetComponent<BulletSpawner>();

        if (bulletSpawner != null)
        {
            // Atk ���� �����Ͽ� ź�� �߻�
            bulletSpawner.SpawnBullet(Atk);
            SoundManager.s.PlayFXSound(atkSound);
        }
    }
}
