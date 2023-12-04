using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBulletController : BulletController
{
    public override void MoveBullet()
    {
        transform.Translate(Vector2.right * (speed * Time.deltaTime), Space.Self);
    }

    public override void HandleCollision(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Info playerInfo = other.GetComponent<Info>();
            if (playerInfo != null)
            {
                playerInfo.DamageResult(dmg);
                Destroy(gameObject);
                Debug.Log($"{dmg} ������!! �÷��̾��� ���� ü�� {playerInfo.Hp}");
            }
            else
            {
                Debug.LogError("'Player' �±׸� ���� ��ü���� Info ������Ʈ�� ã�� �� �����ϴ�.");
            }
        }
    }
}
