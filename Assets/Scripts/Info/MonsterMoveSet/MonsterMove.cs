using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour
{
    float limitY;
    void Start()
    {
        limitY = Random.Range(-0.5f, -1.5f);
    }

    void Update()
    {
        if (transform.position.y >= limitY) transform.position += new Vector3(0f, -0.05f, 0f);
    }
}
