using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomItem : MonoBehaviour
{
    GameObject boom;
    // Start is called before the first frame update
    void Start()
    {
        boom = transform.GetChild(2).gameObject;
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Boom")
        {
            GetItemText.GT.TextOn(4);
            boom.SetActive(true);
            Invoke("BoomOff", 2f);
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

            Destroy(coll.gameObject);
        }

    }

    private void BoomOff()
    {
        boom.SetActive(false);
    }
}
