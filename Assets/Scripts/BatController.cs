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
     
        if (Input.touchCount > 0)
        {
            float mouseRatioX = (Input.GetTouch(0).position.x) / Screen.width; //-0.5 y 0.5}
            float mouseNormX = mouseRatioX - 0.5f;
            float batTargetPos = mouseNormX * 8.6f;
       
            
            Vector3 batNewPosVec = new Vector3(batTargetPos, -6f, 0f);

          

            transform.position = Vector3.MoveTowards(transform.position, batNewPosVec, speed * Time.deltaTime);

       



        }





    }
}
