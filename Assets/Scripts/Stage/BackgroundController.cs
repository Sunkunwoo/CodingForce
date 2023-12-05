using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    float height;
    float speed;
    BoxCollider2D collider2D;
    [SerializeField] GameObject BossBgImg;
    [SerializeField] GameObject BossBgImg2;
    // Start is called before the first frame update
    void Start()
    {
        collider2D = GetComponent<BoxCollider2D>();
        height = collider2D.size.y;
        speed = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        changeBgImg();
        ScrollDown();
        if(transform.position.y <= -height)
        {
            Reposition();
        }
    }
    void changeBgImg()
    {
        if (GameManager.I.bossCheck == true)
        {
            BossBgImg.SetActive(true);
            BossBgImg2.SetActive(true);
        }
        else
        {
            BossBgImg.SetActive(false);
            BossBgImg2.SetActive(false);
        }
    }
    void ScrollDown()
    {
        transform.Translate(Vector3.down*speed *Time.deltaTime);
    }
    void Reposition()
    {
        Vector3 offset = new Vector3(0, height * 2, 0);
        transform.position = transform.position + offset;
    }
}
