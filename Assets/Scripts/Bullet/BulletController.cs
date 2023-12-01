using UnityEngine;

public class BulletController : MonoBehaviour
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
        transform.Translate(Vector2.right * (Speed * Time.deltaTime), Space.Self);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other != null && other.CompareTag("User"))
        {
            Info playerInfo = other.GetComponent<Info>();
            if (playerInfo != null)
            {
                playerInfo.DamageResult(dmg);
                Destroy(gameObject);
                Debug.Log(dmg + "������!! " + "�÷��̾��� ���� ü��" + playerInfo.Hp);
            }
            else
            {
                Debug.LogError("'User' �±׸� ���� ��ü���� Info ������Ʈ�� ã�� �� �����ϴ�.");
            }
        }
    }
}
