using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioSource effectSource;
    public AudioSource bgmSource;

    public List<AudioClip> bgmList = new List<AudioClip>();

    public AudioClip lobbySound;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);

        bgmSource.volume -= 0.5f;
    }

    public void PlayEffectSound(AudioClip clip)
    {
        effectSource.clip = clip;
        effectSource.Play();
    }

    public void PlayBgmSound(AudioClip clip)
    {
        if(bgmSource.isPlaying) bgmSource.Stop();
        bgmSource.clip = clip;
        bgmSource.Play();
    }

    public void StopBgmSound()
    {
        bgmSource.Stop();
    }
}
