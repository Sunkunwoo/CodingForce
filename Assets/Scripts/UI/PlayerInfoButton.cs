using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfoButton : MonoBehaviour
{
    public GameObject InfoUI;
    public GameObject AvatarBtn;
    public GameObject OptionBtn;
    // Start is called before the first frame update
    public void Onclick()
    {
        if (InfoUI.activeSelf == true)
        {
            InfoUI.SetActive(false);
            AvatarBtn.SetActive(false);
            OptionBtn.SetActive(false);
        }

        else if (InfoUI.activeSelf == false)
        {
            InfoUI.SetActive(true);
            AvatarBtn.SetActive(true);
            OptionBtn.SetActive(true);
        }

    }
}
