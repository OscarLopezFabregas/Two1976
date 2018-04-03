using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public GameObject particles;
    public Points points;

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(particles, transform.position, Quaternion.identity);
        Destroy(gameObject);
        transform.SetParent(null);
        points.WinPoints();
    }
    //TODO: POWER UP, WHEN POWER UP ON, ISTRIGGER = TRUE, AND USE ONTRIGGERENTER;
   
}
