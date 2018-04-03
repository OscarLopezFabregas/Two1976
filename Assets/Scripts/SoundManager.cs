using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {
    public AudioSource bounce;
    public AudioSource point;

    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.CompareTag("Brick"))
        {
            point.Play();
        }
        else
        {
            bounce.Play();
        }
        
    }
}
