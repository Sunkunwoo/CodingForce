using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Info;

public class RandomColorSprite : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        if (GameManager.I.isColored == false)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();

            if (spriteRenderer == null)
            {
                spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
            }
            spriteRenderer.color = Color.white;
        }
        else
        {
            spriteRenderer = GetComponent<SpriteRenderer>();

            if (spriteRenderer == null)
            {
                spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
            }
            SetRandomColor();
        }
    }

    private void SetRandomColor()
    {
        Color randomColor = new Color(Random.value, Random.value, Random.value);

        randomColor.a = 1f;

        spriteRenderer.color = randomColor;
    }
}
