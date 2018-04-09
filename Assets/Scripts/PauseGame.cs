using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {

    public static bool gameIsPaused = false;
    public void Pause()
    {
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
    
}
