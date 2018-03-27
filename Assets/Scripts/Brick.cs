using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public GameObject particles;

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(particles, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    //TODO: POWER UP, WHEN POWER UP ON, ISTRIGGER = TRUE, AND USE ONTRIGGERENTER;
   
}
