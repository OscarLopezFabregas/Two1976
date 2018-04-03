using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    Rigidbody rb;
    public float initialSpeed = 600f;
    bool inGame = false;
    Vector3 initPos;
    Transform bat;
    public float speedY = 10f;

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
    void OnCollisionExit(Collision hit)
    {
        float ballBatDistance = (transform.position.x
            - hit.gameObject.transform.position.x);
        //If it was the top or bottom of the screen...
        //1st option to increase the speed while playing
        if (hit.gameObject.name == "Right")
        {

        }
        if (hit.gameObject.tag == "Left")
        {

        }
        if (hit.gameObject.tag == "Top")
        {

        }
        //If it was one of the bats
        if (hit.gameObject.name == "Bat")
        {
            if (ballBatDistance > 0)
            {
                if(ballBatDistance > 0.3)
                rb.velocity = new Vector3(4, speedY);
                else
                rb.velocity = new Vector3(2, speedY);

            }
            if (ballBatDistance < 0)
            {

                if (ballBatDistance <- 0.3)
                    rb.velocity = new Vector3(-4, speedY);
                else
                    rb.velocity = new Vector3(-2, speedY);

            }

        }
    }

}
