using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    Rigidbody rb;
    public float initialSpeed = 600f;
    bool inGame = false;
    Vector3 initPos;
    Transform bat;
    private void Awake()
    {
        bat = transform.parent;
        rb = GetComponent<Rigidbody>();
       
    }

    // Use this for initialization
    void Start ()
    {
        initPos = transform.position;
	}

    public void Reset()
    {
        transform.position = initPos;
        transform.SetParent(bat);
        inGame = false;
        StopMovement();
    }

    public void StopMovement()
    {
        rb.isKinematic = true;
        rb.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update ()
    {
	    if(!inGame && Input.GetButtonDown("Fire1"))
        {
            inGame = true;
            transform.SetParent(null);
            rb.isKinematic = false;
            //TODO: to be able to select the direction of the ball
            rb.AddForce(new Vector3(initialSpeed, initialSpeed, 0));
        }
	}
    //TODO: On collision hit with edges the ball needs to modify its direction by few degrees on Y axis.
}
