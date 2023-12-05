using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using Unity.VisualScripting;
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
                {
                    other.GetComponent<Info>().Hp += 20;
                }
                else if (gameObject == Banana)
                {
                    other.GetComponent<Info>().Atk += 5;
                }
                else if (gameObject == Kiwi)
                {
                    other.GetComponent<Info>().BulletRpm += 10;
                    other.GetComponent<Info>().MoveSpeed += 50;
                }
                else if (gameObject == Pineapple)
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
                }

                Destroy(gameObject);

                Debug.Log("아이템 획득");
            }
            else
            {
                Debug.LogError("'User' 태그를 가진 객체에서 Info 컴포넌트를 찾을 수 없습니다.");
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