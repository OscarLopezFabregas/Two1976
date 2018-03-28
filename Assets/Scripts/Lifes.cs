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
        Lifes.lifes--;
        UpdateLifes();
        Bat.Reset();
        Ball.Reset();
    }
    private void Update()
    {
       
    }
}
