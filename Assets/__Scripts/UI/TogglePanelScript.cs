using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglePanelScript : MonoBehaviour {

    public GameObject Panel;

    protected TogglePanelScript(GameObject panel)
    {
        Panel = panel;
    }

    public void TogglePanel()
    {
        bool isActive = Panel.activeSelf;
        Panel.SetActive(!isActive);
    }

    public void ShowPanel()
    {
        Panel.SetActive(true);
    }

    public void ClosePanel()
    {
        Panel.SetActive(false);
    }
}
