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
                else if (gameObject == Melon)
                    playerInfo.GetItem(5);

                Debug.Log("아이템 획득");
            }
            else
            {
                Debug.LogError("'User' 태그를 가진 객체에서 Info 컴포넌트를 찾을 수 없습니다.");
            }
        }


    }


}