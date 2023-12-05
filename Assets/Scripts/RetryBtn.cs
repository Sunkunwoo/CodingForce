using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetryBtn : MonoBehaviour
{
    public void ReTry()
    {
        GameManager.I.RetryBtn();
    }
}
