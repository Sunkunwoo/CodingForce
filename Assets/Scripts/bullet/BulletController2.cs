using UnityEngine;

public class BulletController2 : MonoBehaviour
{
    public float dmg = 0;
    public float Speed = 10;
    private void Start()
    {
        //생성으로부터 2초 후 삭제
        Destroy(gameObject, 2f);
    }
    public void Initialize(float atk)
    {
        dmg = atk;
    }
    private void Update()
    {
        transform.Translate(Vector2.up * (Speed * Time.deltaTime), Space.Self);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other != null && other.CompareTag("Monster"))
        {
            Info monsterInfo = other.GetComponent<Info>();
            if (monsterInfo != null)
            {
                monsterInfo.DamageResult(dmg);
                Destroy(gameObject);
                Debug.Log(dmg +"데미지!! "+ "몬스터의 남은 체력" + monsterInfo.Hp);
            }
            else
            {
                Debug.LogError("'Monster' 태그를 가진 객체에서 Info 컴포넌트를 찾을 수 없습니다.");
            }
        }
    }
}
