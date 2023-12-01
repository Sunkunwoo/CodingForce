using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmPlayer : MonoBehaviour
{
    public AudioClip audioClip; // AudioClip���� ����
    private AudioSource audioSource; // AudioSource �߰�

    protected virtual void Start()
    {
        audioSource = GetComponent<AudioSource>(); // AudioSource�� ������
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>(); // AudioSource�� ������ �߰�
        }
        audioSource.volume = SoundManager.s.bgmsoundvolume;
        audioSource.clip = audioClip;
        audioSource.loop = true;
        audioSource.Play();
    }
}
