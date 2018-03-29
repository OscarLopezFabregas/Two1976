using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

    public string levelToLoad;
    public float delay = 1f;

    [ContextMenu("StartLoading")]
	public void StartLoading()
    {
        Invoke("LoadLevel", delay);
    }

    void LoadLevel()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public bool IsLastLevel()
    {
      
        return levelToLoad == "Portrait";
        //true or false depends on ^
    }
}
