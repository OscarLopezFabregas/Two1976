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


        if (!inGame && Input.GetMouseButtonUp(0)) //<- Adapted to android;
        {
            inGame = true;
            transform.SetParent(null);
            rb.isKinematic = false;
            //TODO: to be able to select the direction of the ball
            rb.AddForce(new Vector3(initialSpeed, initialSpeed, 0));
        }
	}
    //TODO: On collision hit with edges the ball needs to modify its direction by few degrees on Y axis.
    void OnCollisionEnter(Collision hit)
    {
    
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
        //BUUUUUUGSSSSS!!!

                ///<sumary>
        /// 150º   )135º  )120   )(     60º(    45º(   30º)
        ///(------------------------------------------------------------------)
        /// BAT (bat length, 6 areas)  (bat.size.x/9)
        /// ballBatDistance = 


        
        if (hit.gameObject.name == "Bat" && transform.position.y >= -8.05f)
        {
          float ballBatDistance = (transform.position.x
        - hit.gameObject.transform.position.x);

            Debug.Log("Distance: " + ballBatDistance);

            if (ballBatDistance > -1.4f && ballBatDistance < -1f)
            {
                SetSpeed(rb, -8, speedY);
            }
            else if (ballBatDistance > -1f && ballBatDistance < -0.5f)
            {
                SetSpeed(rb, -4, speedY);
            }
            else if (ballBatDistance > -0.5f && ballBatDistance < 0f)
            {
                SetSpeed(rb, -2, speedY);
            }
            else if (ballBatDistance > 0f && ballBatDistance < 0.5f)
            {
                SetSpeed(rb, 2, speedY);
            }
            else if (ballBatDistance > 0.5f && ballBatDistance < 1f)
            {
                SetSpeed(rb, 4, speedY);
            }
            else if (ballBatDistance > 1f && ballBatDistance < 1.4f)
            {
                SetSpeed(rb, 8, speedY);
            }
        }
    }

    void SetSpeed (Rigidbody rb, float speedX, float speedY) 
    {
        rb.velocity = new Vector3(speedX, speedY);
        Debug.Log("Ball speed: " + rb.velocity);
    }
}
