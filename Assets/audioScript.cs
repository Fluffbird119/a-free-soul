using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioScript : MonoBehaviour
{
    // audio source
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    // audio clip
    public AudioClip backgroundMusic;
    public AudioClip cageHit;
    public AudioClip cageBreak;
    public AudioClip winNoise;

    private void Start()
    {
        musicSource.clip = backgroundMusic;
        musicSource.Play();
    }
}
