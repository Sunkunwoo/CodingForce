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
    float spwanTime;
    int stageTargetPoint;
    int stageNumber;

    // Start is called before the first frame update
    void Start()
    {
        stageNumber = GameManager.I.stage;
        switch (stageNumber)
        {
            case 1:
                stageTargetPoint = 100;
                spwanTime = 5;
                break;
            case 2:
                stageTargetPoint = 300;
                spwanTime = 3;
                break;
            case 3:
                stageTargetPoint = 600;
                spwanTime = 2;
                break;
        }
        InvokeRepeating("Spawns", 0.5f, spwanTime);
        InvokeRepeating("ClearStage", 0, 1f);
    }

    void Spawns()
    {
        if (GameManager.I.sccore < stageTargetPoint)
        {
            int spawnsDice = Random.Range(1, 10);
            switch (spawnsDice)
            {
                case 1:
                case 2:
                case 3:
                    Instantiate(spwanMonster);
                    break;
                case 4:
                case 5:
                case 6:
                    Instantiate(spwanMonster2);
                    break;
                case 7:
                case 8:
                case 9:
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
