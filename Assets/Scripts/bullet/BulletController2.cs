using UnityEngine;

public class BulletController2 : MonoBehaviour
{
    public float dmg = 0;
    public float Speed = 10;
    private void Start()
    {
        //�������κ��� 2�� �� ����
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
                Debug.Log(dmg +"������!! "+ "������ ���� ü��" + monsterInfo.Hp);
            }
            else
            {
                Debug.LogError("'Monster' �±׸� ���� ��ü���� Info ������Ʈ�� ã�� �� �����ϴ�.");
            }
        }
    }
}
