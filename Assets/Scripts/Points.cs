using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Points : MonoBehaviour {

    static public int points = 0;
    public Text textPoints;
    public GameObject levelCompleted;
    public GameObject gameCompleted;

    public NextLevel nextLevel;
    public BallController ball;
    public BatController bat;
    public Transform brickContainer;

    public SoundEndGame soundEndGame;

    // Use this for initialization
    void Start ()
    {
        UpdatePoints();
	}

    void UpdatePoints()
    {
        textPoints.text = "Points: " + Points.points;
    }

	public void WinPoints()
    {
        Points.points++;
        UpdatePoints();

        if(brickContainer.childCount <=0)
        {
            soundEndGame.LevelCompleted();
            ball.StopMovement();
            bat.enabled = false;
            if(nextLevel.IsLastLevel())
            {
                gameCompleted.SetActive(true);
            }

            nextLevel.StartLoading();
        }
    }
}
