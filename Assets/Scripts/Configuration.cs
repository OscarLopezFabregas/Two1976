using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Configuration : MonoBehaviour {

    //set up the config of the game and remember it
    //bools are set to true (1)
    // false (0)
    private void Start()
    {
       if(!PlayerPrefs.HasKey("music"))
        {
            PlayerPrefs.SetInt("music", 1);
        }
        if(!PlayerPrefs.HasKey("sound"))
        {
            PlayerPrefs.SetInt("sound", 1);
        }
        if (!PlayerPrefs.HasKey("Lifes"))
        {
            PlayerPrefs.SetInt("Lifes", 3);
        }
    }

    public void DeleteAllPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }
    
}
