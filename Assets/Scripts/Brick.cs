using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public GameObject particles;
    public Points points;
    public int hits = 1;
    Material mat;
    private void Start()
    {
        mat = GetComponent<Renderer>().material;
    }
    private void OnCollisionEnter(Collision collision)
    {
        hits--;
    

        if(hits<=0)
        {
            Instantiate(particles, transform.position, Quaternion.identity);
            Destroy(gameObject);
            transform.SetParent(null);
        }

        mat.color = Color.yellow;
        points.WinPoints();
    }
    //TODO: POWER UP, WHEN POWER UP ON, ISTRIGGER = TRUE, AND USE ONTRIGGERENTER;
   
}
