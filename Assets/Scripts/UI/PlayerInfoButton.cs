using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfoButton : MonoBehaviour
{
    public GameObject InfoUI;
    // Start is called before the first frame update
    public void Onclick()
    {
        if (InfoUI.activeSelf == true)
            InfoUI.SetActive(false);
        else if (InfoUI.activeSelf == false)
            InfoUI.SetActive(true);
    }
}
