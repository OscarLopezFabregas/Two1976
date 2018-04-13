using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Countdown : MonoBehaviour
{
  
    public static float timeLeft;
   

    public void StartCountdown(float startTimeCountSeconds)
    {
        Countdown.timeLeft = startTimeCountSeconds;
    }

    private void Update()
    {
        if(timeLeft>0)
        {
            Countdown.timeLeft -= Time.deltaTime;
            int temp = (int)Countdown.timeLeft;
            Debug.Log(temp);
        }
       
      
    }
    

}
