using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour
{

    void MobMove()
    {
        if (transform.position.x >= -8.5f && transform.position.x <= 8f && transform.position.y <= 4f && transform.position.y >= 0.5f)
        {
                transform.position += new Vector3(transform.position.x, -1f, 0f);
        }
        else
        {
            CancelInvoke("MobMove");
        }
    }

    void Start()
    {
        InvokeRepeating("MobMove", 0.1f, 0.1f);
    }

}
