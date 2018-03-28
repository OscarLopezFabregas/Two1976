using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitGame : MonoBehaviour {

    public bool exit;
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (exit)
            {
                Application.Quit();
            }
            else
            {
                SceneManager.LoadScene("Portrait");
            }
        }
	}
}
