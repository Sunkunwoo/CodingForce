using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBtn : MonoBehaviour
{
    public GameObject background;
    // Start is called before the first frame update
    public void ChangeOkay()
    {
        background.SetActive(false);
        Time.timeScale = 1f;
    }
    public void ChangeStart()
    {
        background.SetActive(true);
        Time.timeScale = 0f;
    }
}
