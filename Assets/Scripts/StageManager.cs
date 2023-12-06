using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{
    public GameObject spwanMonster;
    public GameObject spwanMonster2;
    public GameObject spwanMonster3;
    public GameObject bossSpwan;
    public GameObject txtUi;
    public GameObject ObjectSpawner;
    public GameObject MousePointer;
    public GameObject GamaUi;

    float spwanTime;
    int stageNumber;
    int targetKill;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(GamaUi);
        GameManager.I.killCount = 0;
        stageNumber = GameManager.I.stage;
        switch (stageNumber)
        {
            case 1:
                spwanTime = 5;
                targetKill = 10;
                break;
            case 2:
                targetKill = 20;
                spwanTime = 3;
                break;
            case 3:
                targetKill = 30;
                spwanTime = 2;
                break;
        }
        InvokeRepeating("Spawns", 0.5f, spwanTime);
        InvokeRepeating("ClearStage", 0, 1f);
        //Instantiate(ObjectSpawner);
        Instantiate(MousePointer);
    }

    private void Update()
    {
        if (GameManager.I.clearCheck == true)
        {
            txtUi.SetActive(true);
            Time.timeScale = 0f;
            if (Input.GetKeyDown(KeyCode.Return))
            {   
                Time.timeScale = 1f;
                GameManager.I.clearCheck = false;
                if (GameManager.I.stage < 4)
                {
                    SceneManager.LoadScene("Stage" + GameManager.I.stage);
                    Instantiate(ObjectSpawner);
                }
                else
                {
                    SceneManager.LoadScene("Ending");
                }
            }
        }
        else 
        {
            txtUi.SetActive(false);
        }
    }

    void Spawns()
    {
        if (GameManager.I.SpwanCount < 10)
        {
            if (GameManager.I.killCount <= targetKill)
            {
                MonsterSpwanDice();
            }
            else
            {
                if (GameManager.I.bossCheck == false)
                {
                    Instantiate(bossSpwan);
                }
                else
                {
                    MonsterSpwanDice();
                }
                GameManager.I.bossCheck = true;
                if (GameManager.I.stage <= 2)
                {
                    CancelInvoke("Spawns");
                }
            }

        }
        else
        {
            Debug.Log("생성 제한 초과");
        }

    }

    void MonsterSpwanDice()
    {
        int spawnsDice = Random.Range(1, 10);
        switch (spawnsDice)
        {
            case 1:
            case 2:
            case 3:
                GameManager.I.SpwanCount++;
                Instantiate(spwanMonster);
                break;
            case 4:
            case 5:
            case 6:
                GameManager.I.SpwanCount++;
                Instantiate(spwanMonster2);
                break;
            case 7:
            case 8:
            case 9:
                GameManager.I.SpwanCount++;
                Instantiate(spwanMonster3);
                break;
            default:
                Debug.Log("디폴트");
                break;
        }
    }

}
