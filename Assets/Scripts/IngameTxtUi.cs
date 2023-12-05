using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class IngameTxtUi : MonoBehaviour
{
    public TextMeshProUGUI scoreTxt;
    public TextMeshProUGUI hpTxt;
    public TextMeshProUGUI stageTxt;
    public GameObject player; // GameObject Ÿ������ ����

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        //DontDestroyOnLoad(this.gameObject);
        //SceneManager.sceneLoaded += OnSceneLoadedUi;
        //gameObject.SetActive(false);
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

    //void OnSceneLoadedUi(Scene scene, LoadSceneMode mode)
    //{
    //    if (scene.name == "Lobby" || scene.name == "Ending")
    //    {
    //        gameObject.SetActive(false);
    //    }
    //    else
    //    {
    //        gameObject.SetActive(true);
    //    }
    //}
    //void OnDestroy()
    //{
    //    // ������Ʈ�� �ı��� �� �̺�Ʈ���� �޼��� ����
    //    SceneManager.sceneLoaded -= OnSceneLoadedUi;
    //}
}
