using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoSingleton<SoundManager>
{
    public AudioSource effectSource;
    public AudioSource bgmSource;

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
