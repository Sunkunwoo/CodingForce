using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerAddHide : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        SceneManager.sceneLoaded += OnSceneLoaded; //다른 씬으로 넘어갈때 쓰이는 sceneLoaded가 호추될때 OnSceneLoaded도 호출 
    }

    // Update is called once per frame
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Title" || scene.name == "Lobby" || scene.name == "Ending") // 플레이어 오브젝트가 안보이게 하고싶은 씬의 이름을 추가해야합니다.
        {
            DisablePlayerShoot();
            gameObject.SetActive(false);
        }
        else
        {
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
        // 컴포넌트가 파괴될 때 이벤트에서 메서드 제거
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
 