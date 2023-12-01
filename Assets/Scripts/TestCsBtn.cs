using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestCsBtn : MonoBehaviour
{
    public void LoadBattle()
    {
        SceneManager.LoadScene("Stage"+GameManager.I.stage);
    }
}
