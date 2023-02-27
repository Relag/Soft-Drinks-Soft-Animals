using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance;
    public AudioSource bgmSource;
    public AudioSource sfxSource;
    public AudioClip[] audioClips;
    
    // Singleton pattern to ensure only one AudioManager exists at the same time.
    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(transform.gameObject);

        
    }

    private void Start() {
        bgmSource.clip = audioClips[0];
        bgmSource.loop = true;
        bgmSource.Play();
    }

    //Call this when you want to change the song. Check Audiomanager for track listings.
    public void changeSong(int track) {
        if (track < audioClips.Length)
            bgmSource.clip = audioClips[track];
        bgmSource.Play();
    }
}
