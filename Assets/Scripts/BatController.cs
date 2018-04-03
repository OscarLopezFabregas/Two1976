using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BatController : MonoBehaviour {

    public float speed = 0.4f;
   
    Vector3 initPos;
	// Use this for initialization
	void Start ()
    {
        initPos = transform.position;
	}

    public void Reset()
    {
        transform.position = initPos;
    }

    // Update is called once per frame
    void Update ()
    {
        float horizontalKeyboard = Input.GetAxisRaw("Horizontal");
        float posX = transform.position.x + horizontalKeyboard * speed * Time.deltaTime;

        transform.position = new Vector3(Mathf.Clamp(posX, -4.3f, 4.3f), transform.position.y, transform.position.z);
	}
}
