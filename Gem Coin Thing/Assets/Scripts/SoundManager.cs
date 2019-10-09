using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioSource audioSource;
    public AudioClip coinCollectSound;
    public AudioClip hitBoxSound;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void PlayCoinCollectSound()
    {
        audioSource.clip = coinCollectSound;
        audioSource.Play();
    }

    public void PlayHitBoxColideSound()
    {
        audioSource.clip = hitBoxSound;
        audioSource.Play();
    }








}
