using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class BulletController : MonoBehaviour
{
    public float dmg = 0;
    public float Speed {get { return speed; } set { speed = value; }}
    public float speed = 3;

    private void Start()
    {
        // 2ÃÊ ÈÄ¿¡ ÆÄ±«
        Destroy(gameObject, 2f);
    }

    public void Initialize(float attack)
    {
        dmg = attack;
    }

    private void Update()
    {
        MoveBullet();
    }

    public virtual void MoveBullet()
    {
        
    }

    public virtual void HandleCollision(Collider2D other)
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other == null)
        {
            return;
        }

        HandleCollision(other);
    }
}
