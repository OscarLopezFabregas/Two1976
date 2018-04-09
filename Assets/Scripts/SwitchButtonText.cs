using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchButtonText : MonoBehaviour {
   

	public void SwitchText(GameObject text)
    {
        if (text.activeSelf)
        {
            text.SetActive(false);
        }
        else
            text.SetActive(true);
    }
}
