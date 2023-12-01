using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class IngameTxtUi : MonoBehaviour
{
    public TextMeshProUGUI scoreTxt;
    public TextMeshProUGUI hpTxt;
    public TextMeshProUGUI stageTxt;

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = "Score: " + GameManager.I.sccore;
        hpTxt.text = "Hp" + GameManager.I._Playerinfo.Hp;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Lobby" || scene.name == "Ending") // 플레이어 오브젝트가 안보이게 하고싶은 씬의 이름을 추가해야합니다.
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
}
