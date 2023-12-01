using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class IngameTxtUi : MonoBehaviour
{
    public TextMeshProUGUI scoreTxt;
    public TextMeshProUGUI hpTxt;
    public TextMeshProUGUI stageTxt;
    public GameObject player; // GameObject 타입으로 변경

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        SceneManager.sceneLoaded += OnSceneLoadedUi;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            stageTxt.text = "Stage" + GameManager.I.stage.ToString();
                scoreTxt.text = "Score: " + GameManager.I.sccore.ToString();
            hpTxt.text = "Hp: " + player.GetComponent<PlayerInfo>().Hp.ToString();
        }
    }

    void OnSceneLoadedUi(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Lobby" || scene.name == "Ending")
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
}
