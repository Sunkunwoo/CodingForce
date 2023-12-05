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
        // �浹�� ������Ʈ�� �±װ� "PlayerBullet"���� Ȯ��
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
