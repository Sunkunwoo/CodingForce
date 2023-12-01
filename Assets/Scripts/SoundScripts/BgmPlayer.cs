using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmPlayer : MonoBehaviour
{
    public AudioClip audioClip; // AudioClip으로 수정
    private AudioSource audioSource; // AudioSource 추가

    protected virtual void Start()
    {
        audioSource = GetComponent<AudioSource>(); // AudioSource를 가져옴
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>(); // AudioSource가 없으면 추가
        }
        audioSource.volume = SoundManager.s.bgmsoundvolume;
        audioSource.clip = audioClip;
        audioSource.loop = true;
        audioSource.Play();
    }
}
