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

            // AudioSource ������Ʈ�� �������ų� �߰��մϴ�.
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
            // ���� ��� ���� BGM�� ����
            StopBgm();

            // ���ο� BGM�� �����ϰ� ���
            audioSource.clip = bgmClip;
            audioSource.volume = bgmsoundvolume;
            audioSource.Play();
        }
    }

    public void StopBgm()
    {
        // ���� ��� ���� BGM�� ����
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
