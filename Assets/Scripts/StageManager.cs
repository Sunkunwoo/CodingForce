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
    float spwanTime;
    int stageNumber;
    int targetKill;

    // Start is called before the first frame update
    void Start()
    {
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
        Instantiate(ObjectSpawner);
        Instantiate(MousePointer);
    }

    void Spawns()
    {
        if (GameManager.I.SpwanCount < 10)
        {
            if (GameManager.I.killCount <= targetKill)
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
                }
            }
            else
            {
                Instantiate(bossSpwan);
                CancelInvoke("Spawns");
            }

        }
        else;
        {
            Debug.Log("생성 제한 초과");
        }

    }

    void ClearStage()
    {
        if(stageNumber != GameManager.I.stage)
        {
            txtUi.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene("LOBBY");
            }
        }
    }

}
