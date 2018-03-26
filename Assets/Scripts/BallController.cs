using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    Rigidbody rb;
    public float initialSpeed = 600f;
    bool inGame = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Use this for initialization
    void Start ()
    {
         
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(!inGame && Input.GetButtonDown("Fire1"))
        {
            inGame = true;
            transform.SetParent(null);

        }
	}
}
