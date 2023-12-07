using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndAnimController : MonoBehaviour
{
    [SerializeField] Animator endAnimController;
    [SerializeField] GameObject GameOverTxt;

    private void Awake()
    {
        endAnimController = GetComponent<Animator>();
    }
    private void Update()
    {
        if (endAnimController.GetCurrentAnimatorStateInfo(0).IsName("EndingScreen") == true){
            if (endAnimController.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
            {
                GameOverTxt.SetActive(true);
                getPlayerKeycode();
            }
        }
    }
    private void getPlayerKeycode()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
        else if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Title");
        }

    }
}