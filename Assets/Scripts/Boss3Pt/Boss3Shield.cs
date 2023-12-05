using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss3Shield : MonoBehaviour
{
    int shiledGard = 4;
    public Transform target;
    float rotationSpeed = 300;
    void Update()
    {
        if (target != null)
        {
            transform.RotateAround(target.position, Vector3.forward, rotationSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 충돌한 오브젝트의 태그가 "PlayerBullet"인지 확인
        if (collision.CompareTag("PlayerBullet"))
        { 
            Rigidbody2D bulletRb = collision.GetComponent<Rigidbody2D>();
            if (bulletRb != null)
            {
                Destroy(collision.gameObject);
                shiledGard  -= 1;
            }

            if(shiledGard == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
