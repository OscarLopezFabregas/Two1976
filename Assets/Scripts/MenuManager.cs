﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class MenuManager : MonoBehaviour {
    public GameObject options;
    public AudioMixer gameAudio;

	public void Activate(GameObject panel)
    {
        panel.transform.SetAsLastSibling();
        panel.SetActive(true);
    }

    public void Deactivate(GameObject panel)
    {
        panel.SetActive(false);
    }

    public void toggleMixer (string audioName)
    {
        float value;
        gameAudio.GetFloat(audioName, out value);
        if (value==0f)
        gameAudio.SetFloat(audioName, -80f);
        else
        gameAudio.SetFloat(audioName, 0f);
              
    }

}