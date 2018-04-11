using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lifes : MonoBehaviour {

    //static forces int lifes to exist only ONCE in the whole app.
    //Global
    //We will be able to access from everywhere in the program
    public static int lifes;
    public Text lifeText;
    public BallController Ball;
    public BatController Bat;
    public GameObject gameOver;
    public NextLevel nextLevel;
    public SoundEndGame soundEndGame;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("Lifes")) PlayerPrefs.SetInt("Lifes", 3);
        Lifes.lifes = PlayerPrefs.GetInt("Lifes");
        UpdateLifes();
    }

    void UpdateLifes()
    {
        lifeText.text = "Lifes: " + Lifes.lifes;
        PlayerPrefs.SetInt("Lifes", Lifes.lifes);
        


        }
    public void MinusOneLife()
    {
     
            Lifes.lifes--;
            UpdateLifes();
            soundEndGame.Error();
            Bat.Reset();
            Ball.Reset();
            
        
     
    }
   public void GameOver()
    {
        Bat.enabled = false;
        Ball.enabled = false;
        soundEndGame.GameOver();
        gameOver.SetActive(true);
        Ball.StopMovement();
        //For the moment lifes will be reset on gameOver condition
        nextLevel.levelToLoad = "Portrait";
              

        nextLevel.StartLoading();
    }
    private void Update()
    {
       
    }
}
