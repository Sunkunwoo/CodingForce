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
                Debug.Log($"{dmg} 데미지!! 몬스터의 남은 체력 {monsterInfo.Hp}");
            }
            else
            {
                Debug.LogError("'Monster' 태그를 가진 객체에서 Info 컴포넌트를 찾을 수 없습니다.");
            }
        }
    }
}
