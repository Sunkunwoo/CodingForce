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
                Debug.Log($"{dmg} 데미지!! 플레이어의 남은 체력 {playerInfo.Hp}");
            }
            else
            {
                Debug.LogError("'Player' 태그를 가진 객체에서 Info 컴포넌트를 찾을 수 없습니다.");
            }
        }
    }
}
