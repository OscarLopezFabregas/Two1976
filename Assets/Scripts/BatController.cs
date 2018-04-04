using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BatController : MonoBehaviour {

    public float speed = 0.4f;
    Rigidbody rb;
    Vector3 initPos;

	void Start ()
    {
        initPos = transform.position;
        rb = GetComponent<Rigidbody>();
	}

    public void Reset()
    {
        transform.position = initPos;
    }


    void Update()
    {
        //PC CONTROLLER

        //float horizontalKeyboard = Input.GetAxisRaw("Horizontal");
        //float posX = transform.position.x + horizontalKeyboard * speed * Time.deltaTime;
        //transform.position = new Vector3(Mathf.Clamp(posX, -4.3f, 4.3f), transform.position.y, transform.position.z);

        //ANDROID CONTROLLER

        rb.velocity = new Vector3(0f, 0f, 0f);

       
        float mouseRatioX = (Input.GetTouch(0).position.x -0.5f) / Screen.width; //-0.5 y 0.5
        float batPosX = transform.position.x / 8.6f; //-0.5 y 0.5
        float distance = batPosX - mouseRatioX;

       


        if (distance > 0.0f)
        { rb.velocity = new Vector3(speed, 0f, 0f); }
        else if (distance < -0.0f)
        { rb.velocity = new Vector3(speed, 0f, 0f); }
        //float nTouchPosition = (touch.position.x - (1080 / 2)) / (1080 / 2);
        // float distance = touch.position.x - transform.position.x;

        // if (distance >= 0f)
        // { rb.velocity = new Vector3(speed, 0f, 0f);}       
        //else
        // { rb.velocity = new Vector3(speed, 0f, 0f);}


    }
}
