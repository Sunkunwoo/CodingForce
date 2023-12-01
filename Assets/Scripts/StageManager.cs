using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{
    public GameObject spwanMonster;
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
            Instantiate(spwanMonster);
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
