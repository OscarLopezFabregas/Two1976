using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lifes : MonoBehaviour {

    //static forces int lifes to exist only ONCE in the whole app.
    //Global
    //We will be able to access from everywhere in the program
    public static int lifes = 3;
    public Text lifeText;
    public BallController Ball;
    public BatController Bat;
    public GameObject gameOver;
    public NextLevel nextLevel;

    private void Start()
    {
        UpdateLifes();
    }

    void UpdateLifes()
    {
        lifeText.text = "Lifes: " + Lifes.lifes;

    }
    public void MinusOneLife()
    {
        if (Lifes.lifes <= 0) return; //Security check
        Lifes.lifes--;
        UpdateLifes();

        if(Lifes.lifes <= 0)
        {
            gameOver.SetActive(true);
            Ball.StopMovement();
            Bat.enabled = false;

            nextLevel.levelToLoad = "Portrait";
            nextLevel.StartLoading();
        }
        else
        {
            Bat.Reset();
            Ball.Reset();
        }
        
    }
    private void Update()
    {
       
    }
}
