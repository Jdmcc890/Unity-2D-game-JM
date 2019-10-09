using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioSource audioSource;
    public AudioClip coinCollectSound;

    private void Awake()
    {
        Instance = this;  
    }

    public void PlayCoinCollectSound()
    {
        audioSource.clip = coinCollectSound;
        audioSource.Play();
    }









}
