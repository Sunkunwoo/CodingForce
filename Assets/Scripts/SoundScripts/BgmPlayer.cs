using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmPlayer : MonoBehaviour
{
    public AudioClip audioClip; // AudioClip���� ����
    private AudioSource audioSource; // AudioSource �߰�

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // AudioSource�� ������
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>(); // AudioSource�� ������ �߰�
        }
        SoundManager.s.PlayBgm(audioClip);
    }
}
