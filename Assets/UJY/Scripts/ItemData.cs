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
    static GameObject Shield;
    public AudioClip getSound;


    //public AudioClip ItemSound;


    void Start()
    {
        float x = Random.Range(-8f, 8f);
        float y = 4;
        transform.position = new Vector3(x, y, 0);
        if(Shield == null)
        {
            Shield = GameObject.FindGameObjectWithTag("Shield");
            Shield.SetActive(false);
        }

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
                    other.GetComponent<Info>().BulletRpm += 5;
                    other.GetComponent<Info>().MoveSpeed += 5;
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
                else if (gameObject == Melon)
                {
                    Debug.Log("쉴드생성");
                    Shield.SetActive(true);
                    Invoke("ShieldOff", 5f);
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

    public void ShieldOff()
    {
        Shield.SetActive(false);
    }


}