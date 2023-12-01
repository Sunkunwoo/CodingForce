using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class IngameTxtUi : MonoBehaviour
{
    public TextMeshProUGUI scoreTxt;
    public TextMeshProUGUI hpTxt;
    public TextMeshProUGUI stageTxt;

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        SceneManager.sceneLoaded += OnSceneLoadedUi;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.I._Playerinfo != null)
        {
            scoreTxt.text = "Score: " + GameManager.I.sccore;
            hpTxt.text = "Hp" + GameManager.I._Playerinfo.Hp;
        }
        else
        {
            Debug.Log("gameManager._PlayInfo Is Null"); 
        }
    }

    void OnSceneLoadedUi(Scene scene, LoadSceneMode mode)
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
