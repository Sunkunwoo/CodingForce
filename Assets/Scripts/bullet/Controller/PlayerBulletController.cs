using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletController : BulletController
{
    public override void MoveBullet()
    {
        transform.Translate(Vector2.up * (speed * Time.deltaTime), Space.Self);
    }

    public override void HandleCollision(Collider2D other)
    {
        if (other.CompareTag("Monster"))
        {
            Info monsterInfo = other.GetComponent<Info>();
            if (monsterInfo != null)
            {
                monsterInfo.DamageResult(dmg);
                Destroy(gameObject);
                Debug.Log($"{dmg} ������!! ������ ���� ü�� {monsterInfo.Hp}");
            }
            else
            {
                Debug.LogError("'Monster' �±׸� ���� ��ü���� Info ������Ʈ�� ã�� �� �����ϴ�.");
            }
        }
    }
}
