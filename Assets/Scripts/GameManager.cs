using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public bool clearCheck=false;
    public int stage=1;
    public int sccore=0;
    public bool isCheat = false;
    public bool isColored = false;
    public int killCount= 0;
    public int SpwanCount = 0;
    public bool bossCheck = false;

    public GameObject player;
    public GameObject ingameUiBox; 
    public GameObject gameOverBox;
    public Character currentCharacter;

    public static GameManager I;

    void Awake()
    {
        if (I != null && I != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            I = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    public void GameOver()
    {
        Instantiate(gameOverBox);
        Time.timeScale = 0f;
    }

    public void RetryBtn()
    {
        stage = 1;
        sccore = 0;
        Time.timeScale = 1f;
        Destroy(ingameUiBox);
        SceneManager.LoadScene("Title");
    }
}