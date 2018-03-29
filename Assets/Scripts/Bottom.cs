using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottom : MonoBehaviour {

    public Lifes lifes;

    private void OnTriggerEnter(Collider other)
    {
        lifes.MinusOneLife();
    }
}
