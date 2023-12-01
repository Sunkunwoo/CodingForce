using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour
{

    private void Move()
    {
        transform.position += new Vector3(transform.position.x, -1f, 0f);
    }
    void Start()
    {
        if(transform.position.x <= -8f && transform.position.x >= 8)
        {
            while(transform.position.y >= 4)
            {
                Move();
            }
        }

    }

}
