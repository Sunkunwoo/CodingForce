using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager s;

    private AudioSource audioSource;
    public float bgmsoundvolume = 0.5f;
    public float fxSoundvolume = 0.5f;

    void Awake()
    {
        if (s == null)
        {
            s = this;
            DontDestroyOnLoad(gameObject);

            // AudioSource 컴포넌트를 가져오거나 추가합니다.
            audioSource = GetComponent<AudioSource>();
            if (audioSource == null)
            {
                audioSource = gameObject.AddComponent<AudioSource>();
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayFXSound(AudioClip soundClip)
    {
        if (soundClip != null)
        {
            audioSource.PlayOneShot(soundClip, fxSoundvolume);
        }
    }

    public void PlayBgm(AudioClip bgmClip)
    {
        if (bgmClip != null)
        {
            // 현재 재생 중인 BGM을 중지
            StopBgm();

            // 새로운 BGM을 설정하고 재생
            audioSource.clip = bgmClip;
            audioSource.volume = bgmsoundvolume;
            audioSource.Play();
        }
    }

    public void StopBgm()
    {
        // 현재 재생 중인 BGM을 중지
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
