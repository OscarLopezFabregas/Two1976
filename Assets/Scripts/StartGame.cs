using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour {

	
	// Update is called once per frame
	void Update ()
    {
	if(Input.GetButtonDown("Fire1"))
        {
            Points.points = 0;
            Lifes.lifes = 3;
            SceneManager.LoadScene("Level1");
        }
	}
}
