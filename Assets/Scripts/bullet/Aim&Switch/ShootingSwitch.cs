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
