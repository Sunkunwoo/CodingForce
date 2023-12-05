using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchHandler : MonoBehaviour
{
    private void OnShootActivator()
    {
        Debug.Log("dasboots");
        // PlayerShoot ��ũ��Ʈ�� ã��
        PlayerShoot playerShoot = FindObjectOfType<PlayerShoot>();

        // playerShoot�� null�� �ƴϸ� ����
        if (playerShoot != null)
        {
            // EnableScript �޼��� ȣ���Ͽ� bool �� ����
            playerShoot.EnableScript(!playerShoot.enabled);
        }
        else
        {
            Debug.LogWarning("PlayerShoot not found.");
        }
    }
}
