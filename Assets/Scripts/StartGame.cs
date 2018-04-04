using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour {

	
	// Update is called once per frame
	void Update ()
    {
        Touch touch = Input.GetTouch(0);
        //	if(Input.GetButtonDown("Fire1"))
        if(touch.phase == TouchPhase.Ended)
        {
            Points.points = 0;
            Lifes.lifes = 3;
            SceneManager.LoadScene("Level1");
        }
	}
}
