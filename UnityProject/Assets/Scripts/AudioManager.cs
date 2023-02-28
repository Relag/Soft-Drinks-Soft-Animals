using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance;
    public AudioSource bgmSource;
    public AudioSource sfxSource;
    public AudioClip[] musicClips;
    public AudioClip[] garbageClips;
    public AudioClip[] sodaClips;
    public AudioClip[] bookClips;
    public AudioClip[] animalClips;
    public AudioClip[] orderComplete;
    private bool audioOn = true;
    private bool sfxOn = true;
    
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
        bgmSource.clip = musicClips[0];
        bgmSource.loop = true;
        bgmSource.Play();
    }

    //Call this when you want to change the song. Track  Listings:
    //0: Main Menu
    //1: Gameplay Loop
    //2: Happy String
    //3: Sad String
    public void changeSong(int track) {
        if (audioOn) {
            if (track < musicClips.Length)
                bgmSource.clip = musicClips[track];
            bgmSource.Play();
        }
    }

    public void garbageSFX() {
        if (sfxOn)
            sfxSource.PlayOneShot(garbageClips[Random.Range(0, garbageClips.Length)]);
    }

    public void bookSFX() {
        if (sfxOn)
            sfxSource.PlayOneShot(bookClips[Random.Range(0, bookClips.Length)]);
    }

    public void sodaSFX() {
        if (sfxOn) {
            sfxSource.PlayOneShot(sodaClips[0]);
            WaitForSeconds(0.2f);
            sfxSource.PlayOneShot(sodaClips[Random.Range(1, sodaClips.Length)]);
        }
    }

    public void stopSodaSFX() {
        sfxSource.Stop();
    }

    public void orderCompleteSFX(bool result) {
        if (sfxOn) {
            if (result)
                sfxSource.PlayOneShot(orderComplete[0]);
            else
                sfxSource.PlayOneShot(orderComplete[1]);
        }
    }

    public void animalSFX() {
        if (sfxOn) {
            sfxSource.PlayOneShot(animalClips[0]);
            WaitForSeconds(0.5f);
            sfxSource.PlayOneShot(animalClips[Random.Range(1, animalClips.Length)]);
        }
    }

    IEnumerator WaitForSeconds(float seconds) {
        yield return new WaitForSeconds(seconds);
    }
}
