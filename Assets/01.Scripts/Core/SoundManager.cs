using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioSource effectSource;
    public AudioSource bgmSource;

    public AudioClip zodiacEnterSource;

    public List<AudioClip> bgmList = new List<AudioClip>();

    public AudioClip lobbySound;
    public AudioClip clickClip;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
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
