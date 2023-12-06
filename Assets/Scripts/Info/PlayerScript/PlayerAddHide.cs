using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerAddHide : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded; //�ٸ� ������ �Ѿ�� ���̴� sceneLoaded�� ȣ�ߵɶ� OnSceneLoaded�� ȣ�� 
    }

    // Update is called once per frame
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Title" || scene.name == "Lobby" || scene.name == "Ending") // �÷��̾� ������Ʈ�� �Ⱥ��̰� �ϰ���� ���� �̸��� �߰��ؾ��մϴ�.
        {
            DisablePlayerShoot();
            gameObject.SetActive(false);
        }
        else if(scene.name == "Stage1" || scene.name == "Stage2" || scene.name == "Stage3")
        {
            DisablePlayerShoot();
            EnablePlayerShoot();
            gameObject.SetActive(true);
        }
    }
    private void DisablePlayerShoot()
    {
        PlayerShoot playerShoot = FindObjectOfType<PlayerShoot>();
        if (playerShoot != null)
        {
            
            playerShoot.EnableScript(false);
        }
    }

    private void EnablePlayerShoot()
    {
        PlayerShoot playerShoot = FindObjectOfType<PlayerShoot>();
        if (playerShoot != null)
        {
            playerShoot.EnableScript(true);
        }
    }

    void OnDestroy()
    {
        // ������Ʈ�� �ı��� �� �̺�Ʈ���� �޼��� ����
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
 