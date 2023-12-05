using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShootingSwitch : MonoBehaviour
{
    private bool isEnabled = true;

    public void SwitchEnableScript(bool enable)
    {
        isEnabled = enable;
    }
    public void OnShootActivator()
    {
        Debug.Log("dasboots");
        // PlayerShoot 스크립트를 찾기
        PlayerShoot playerShoot = FindObjectOfType<PlayerShoot>();

        // playerShoot이 null이 아니면 실행
        if (playerShoot != null)
        {
            // EnableScript 메서드 호출하여 bool 값 전달
            playerShoot.EnableScript(!playerShoot.enabled);
        }
        else
        {
            Debug.LogWarning("PlayerShoot not found.");
        }
    }
}
