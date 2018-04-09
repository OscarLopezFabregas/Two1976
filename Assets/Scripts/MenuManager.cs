using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class MenuManager : MonoBehaviour {
    public GameObject options;

	public void Activate(GameObject panel)
    {
        panel.transform.SetAsLastSibling();
        panel.SetActive(true);
    }

    public void Deactivate(GameObject panel)
    {
        panel.SetActive(false);
    }
}
