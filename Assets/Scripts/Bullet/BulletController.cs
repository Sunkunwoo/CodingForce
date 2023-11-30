using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float dmg = 0;

    public void Initialize(float atk)
    {
        dmg = atk;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("User"))
        {
            Info playerInfo = other.GetComponent<Info>();
            playerInfo.DamageResult(dmg);
            Destroy(gameObject);
            Debug.Log(dmg + "���� ä��" + playerInfo.Hp);
        }
    }
}
