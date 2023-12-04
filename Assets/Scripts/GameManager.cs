using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool clearCheck=false;
    public int stage=1;
    public int sccore=0;
    public bool isCheat = false;
    public int killCount=0;
    public int SpwanCount=0;

    public static GameManager I;

    void Awake()
    {
        I = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
    }

}
