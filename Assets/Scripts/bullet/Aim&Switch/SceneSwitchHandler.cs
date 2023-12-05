using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchHandler : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Title")
        {
            DisablePlayerShoot();
        }
        else if (scene.name == "Stage1")
        {
            EnablePlayerShoot();
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
}
