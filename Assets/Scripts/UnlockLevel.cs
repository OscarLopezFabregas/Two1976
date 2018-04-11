using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockLevel : MonoBehaviour {

    Button button;
    public int Level;

    private void Start()
    {
        button = GetComponent<Button>();
        button.interactable = false;
    }
    private void Update()
    {
        if(PlayerPrefs.GetInt("Level") >= Level)
        {
            button.interactable = true;
        }
    }
}
