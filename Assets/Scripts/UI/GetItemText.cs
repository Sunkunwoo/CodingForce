
using TMPro;
using UnityEngine;

public class GetItemText : ItemData
{
    private TextMeshPro ItemText;
    public static GetItemText GT;

    private void Start()
    {
        ItemText = GetComponentInChildren<TextMeshPro>();
        ItemText.color = new Color32(255, 255, 255, 0);
    }

    private void Awake()
    {
        if (GT == null)
        {
            GT = this;
        }    
    }

    public void TextOn(int num)
    {

        if (num == 1)
        {
            ItemText.color = new Color32(0, 100, 255, 255);
            ItemText.text = "Hp UP!";
            Invoke("TextOff", 2f);
        }
        else if (num == 2)
        {
            ItemText.color = new Color32(255, 30, 0, 255);
            ItemText.text = "ATK UP!";
            Invoke("TextOff", 2f);
        }
        else if (num == 3)
        {
            ItemText.color = new Color32(255, 255, 0, 255);
            ItemText.text = "Speed UP!";
            Invoke("TextOff", 2f);
        }
        else if (num == 4)
        {
            ItemText.color = new Color32(255, 0, 255, 255);
            ItemText.text = "Boom!";
            Invoke("TextOff", 2f);
        }
        else if (num == 5)
        {
            ItemText.color = new Color32(0, 255, 20, 255);
            ItemText.text = "Shield On!";
            Invoke("TextOff", 2f);
        }
    }

    private void TextOff()
    {
        ItemText.color = new Color32(255, 255, 255, 0);
    }


}
