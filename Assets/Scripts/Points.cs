using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Points : MonoBehaviour {

    static public int points = 0;
    public Text textPoints;

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
    }
}
