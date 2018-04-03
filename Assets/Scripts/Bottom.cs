using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottom : MonoBehaviour {

    public Lifes lifes;
    public Transform ball;
    public int minY = -10;

    private void Update()
    {
        if(ball.position.y<minY)
        lifes.MinusOneLife();
    }
    
    
}
