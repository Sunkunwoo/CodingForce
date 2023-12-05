using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool clearCheck=false;
    public int stage=1;
    public int sccore=0;
    public bool isCheat = false;
    public int killCount= 0;
    public int SpwanCount = 0;
    public bool bossCheck = false;

    public GameObject ingameUiBox; 
    public TextMeshProUGUI gameOverTxt;

    public static GameManager I;

    void Awake()
    {
        I = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public void GameOver()
    {
        gameOverTxt.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RetryBtn()
    {
        Destroy(ingameUiBox);
        SceneManager.LoadScene("Title");
        Time.timeScale = 1f;
    }

}
