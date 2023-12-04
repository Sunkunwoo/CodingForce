using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerAddHide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded; //�ٸ� ������ �Ѿ�� ���̴� sceneLoaded�� ȣ�ߵɶ� OnSceneLoaded�� ȣ�� 
    }

    // Update is called once per frame
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
