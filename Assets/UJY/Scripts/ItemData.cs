using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using static Info;

public class ItemData : MonoBehaviour
{
    public GameObject Apple;
    public GameObject Banana;
    public GameObject Kiwi;
    public GameObject Pineapple;
    public GameObject Melon;
    public AudioClip getSound;

    //public AudioClip ItemSound;


    void Start()
    {
        float x = Random.Range(-8f, 8f);
        float y = 4;
        transform.position = new Vector3(x, y, 0);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Info playerInfo = other.GetComponent<Info>();
        if (other != null && other.CompareTag("Player"))
        {
            if (getSound != null)
            {
                SoundManager.s.PlayFXSound(getSound);
            }
            else
            {
                Debug.Log("get Sound is Null");
            }
            if (playerInfo != null)
            {
                if (gameObject == Apple)
                    playerInfo.GetItem(1);
                else if (gameObject == Banana)
                    playerInfo.GetItem(2);
                else if (gameObject == Kiwi)
                    playerInfo.GetItem(3);
                else if (gameObject == Pineapple)
                    playerInfo.GetItem(4);
                else if (gameObject == Melon)
                    playerInfo.GetItem(5);

                Destroy(gameObject);

                Debug.Log("������ ȹ��");
            }
            else
            {
                Debug.LogError("'User' �±׸� ���� ��ü���� Info ������Ʈ�� ã�� �� �����ϴ�.");
            }
        }


    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Collision")
        {
            Destroy(gameObject);
        }

    }


}