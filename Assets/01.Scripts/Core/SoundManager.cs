using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioSource effectSource;
    public AudioSource bgmSource;

    private void Awake()
    {
        Instance = this;
    }

    public void PlayEffectSound(AudioClip clip)
    {
        effectSource.clip = clip;
        effectSource.Play();
    }

    public void PlayBgmSound(AudioClip clip)
    {
        bgmSource.clip = clip;
        bgmSource.Play();
    }
}
