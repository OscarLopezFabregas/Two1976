using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEndGame : MonoBehaviour {
    public AudioSource audioSource;
    public AudioClip completed;
    public AudioClip gameOver;
    public AudioClip error;
    
    public void GameOver()
    {
        PlayClip(gameOver);
    }

    public void LevelCompleted()
    {
        PlayClip(completed);
    }

    public void Error()
    {
        PlayClip(error);
        
    }

    private void PlayClip(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.loop = false;
        audioSource.Play();
    }
}
