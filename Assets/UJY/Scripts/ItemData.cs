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
    public GameObject Mellon;

    //public AudioClip ItemSound;


    void Start()
    {
        float x = Random.Range(-8f, 8f);
        float y = Random.Range(6f, 7f);
        transform.position = new Vector3(x, y, 0);

    }

    void Update()
    {
     
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Info playerInfo = other.GetComponent<Info>();
        if (other != null && other.CompareTag("User"))
        {
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
                else if (gameObject == Mellon)
                    playerInfo.GetItem(5);

                Destroy(gameObject);
                Debug.Log("아이템 획득");
            }
            else
            {
                Debug.LogError("'User' 태그를 가진 객체에서 Info 컴포넌트를 찾을 수 없습니다.");
            }
        }
     

    }

}