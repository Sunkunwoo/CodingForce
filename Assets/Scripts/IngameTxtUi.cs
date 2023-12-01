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
        if (scene.name == "Lobby" || scene.name == "Ending") // �÷��̾� ������Ʈ�� �Ⱥ��̰� �ϰ���� ���� �̸��� �߰��ؾ��մϴ�.
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
}
