using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Burst.Intrinsics.Arm;

public class ShieldItem : MonoBehaviour
{
    private CircleCollider2D shieldCollider;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        shieldCollider = gameObject.GetComponent<CircleCollider2D>();
        spriteRenderer.color = new Color(200 / 255, 255 / 255, 255 / 255, 0 / 255);
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Shield")
        {
            Debug.Log("½¯µå¿Â");
            if(shieldCollider.enabled == false)
            {
                shieldCollider.enabled = !shieldCollider.enabled;
            }
            spriteRenderer.color = new Color(200 / 255, 255 / 255, 255 / 255, 255 / 255);
            Destroy(coll.gameObject);
            Invoke("ShieldOff", 5f);
        }

        if (coll.CompareTag("Mbullet"))
        {
            Rigidbody2D bulletRb = coll.GetComponent<Rigidbody2D>();
            if(bulletRb != null && shieldCollider.enabled == true)
            {
                Debug.Log("ÃÑ¾Ë»èÁ¦");
                Destroy(coll.gameObject);
            }

        }

    }


    private void ShieldOff()
    {
        Debug.Log("½¯µå¿ÀÇÁ");
        shieldCollider.enabled = !shieldCollider.enabled;
        spriteRenderer.color = new Color(200 / 255, 255 / 255, 255 / 255, 0 / 255);
    }

}
