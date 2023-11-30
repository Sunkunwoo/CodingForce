using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmPlayer : MonoBehaviour
{
    public AudioClip audioClip; // AudioClip으로 수정
    private AudioSource audioSource; // AudioSource 추가

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // AudioSource를 가져옴
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>(); // AudioSource가 없으면 추가
        }
        SoundManager.s.PlayBgm(audioClip);
    }
}
