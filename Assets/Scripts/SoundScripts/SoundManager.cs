using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager s;

    private AudioSource audioSource;

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

    public void PlaySound(AudioClip soundClip)
    {
        if (soundClip != null)
        {
            audioSource.PlayOneShot(soundClip, 0.5f);
        }
    }
}
