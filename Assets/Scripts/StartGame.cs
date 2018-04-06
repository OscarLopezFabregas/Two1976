using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour {
    
    public float startingWait = 1f;	
	// Update is called once per frame
	void Update ()
    {
        
        //	if(Input.GetButtonDown("Fire1"))
        if(Input.GetMouseButtonDown(0))
        {
            Points.points = 0;
            Lifes.lifes = 3;
            SceneManager.LoadScene("Map");
        }

        StartCoroutine(StartGameTime());

	}

    IEnumerator StartGameTime()
    {
        yield return new WaitForSeconds(startingWait);

        SceneManager.LoadScene("Map");
        
    }
}
