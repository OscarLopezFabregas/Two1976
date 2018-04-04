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

        foreach (Touch touch in Input.touches)
        {
            float distance = touch.position.x - transform.position.x;
            if (distance > 0.1f)
                rb.velocity= new Vector3(speed, 0f, 0f);
            if (distance < 0.1f)
                rb.velocity = new Vector3(-speed, 0f, 0f);
        }
    }
}
