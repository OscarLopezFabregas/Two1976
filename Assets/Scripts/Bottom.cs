using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script deals with the situation of bat not being able to hit the ball
//In this case we will Lifes -= 1;
//If lifes = 0, countdown start 15s 

public class Bottom : MonoBehaviour {

    public Lifes lifes;
    public Transform ball;
    public int minY = -10;
    //public Countdown count;
    private void Update()
    {
        if(ball.position.y<minY)
        {
            if (Lifes.lifes <= 1)
            {
                Lifes.lifes = 4;
                lifes.GameOver();
               
                //Implementation of the counter:
                              

            }else
            lifes.MinusOneLife();
        }
         
    }
    
    
}
