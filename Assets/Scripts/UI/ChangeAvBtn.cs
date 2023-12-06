using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeAvBtn : MonoBehaviour
{
    public Sprite Red;
    public Sprite Blue;
    public Sprite Green;
    public Sprite Yellow;
    public Sprite Pink;
    public GameObject AvatarBG;
    GameObject player;
    SpriteRenderer spriteRenderer;
    Component component;

    // Start is called before the first frame update
    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        spriteRenderer = player.GetComponent<SpriteRenderer>();
        component = GetComponent<Image>();
    }
    public void ClickRed()
    {
        spriteRenderer.sprite = Red;

    }

    public void ClickBlue()
    {
        spriteRenderer.sprite = Blue;
    }

    public void ClickYellow()
    {
        spriteRenderer.sprite = Yellow;
    }

    public void ClickPink()
    {
        spriteRenderer.sprite = Pink;
    }

    public void ClickGreen()
    {
        spriteRenderer.sprite = Green;
    }

}
