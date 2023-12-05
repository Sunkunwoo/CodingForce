using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomItem : MonoBehaviour
{
    public GameObject Pineapple;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject == Pineapple)
        {
            GameObject[] mbullet = GameObject.FindGameObjectsWithTag("Mbullet");
            GameObject[] monster = GameObject.FindGameObjectsWithTag("Monster");

            for (int i = 0; i < mbullet.Length; i++)
            {
                Destroy(mbullet[i]);
            }

            for (int i = 0; i < monster.Length; i++)
            {
                Destroy(monster[i]);
            }

            Destroy(Pineapple);
        }

    }
}
