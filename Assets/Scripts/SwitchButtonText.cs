using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchButtonText : MonoBehaviour {
    public GameObject textOn;
    public GameObject textOff;
    public string soundName;

    private void Start()
    {
        DisplayOptionsText(soundName);
    }

    public void SwitchText(GameObject text)
    {
        if (text.activeSelf)
        {
            text.SetActive(false);
        }
        else
            text.SetActive(true);
    }

    public void DisplayOptionsText(string configName)
    {
        if (PlayerPrefs.GetInt(configName) == 1)
        {
            textOn.SetActive(true);
            textOff.SetActive(false);
        }
        else
        {
            textOn.SetActive(false);
            textOff.SetActive(true);
        }
    }
}
