using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourPanelScript : MonoBehaviour {

    public GameObject ColourPanel;
    public GameObject SaturationValue;
    public GameObject Hue;
    public static bool visible;

    public void Start()
    {
        visible = false;
    }

    public void TogglePanel()
    {
        visible = !visible;
        ColourPanel.SetActive(!visible);
        SaturationValue.SetActive(!visible);
        Hue.SetActive(!visible);
    }

    private void HideIfClickedOutside(GameObject panel)
    {
        if (Input.GetMouseButton(0) && panel.activeSelf &&
            !RectTransformUtility.RectangleContainsScreenPoint(
                ColourPanel.GetComponent<RectTransform>(),
                Input.mousePosition,
                Camera.main))
        {
            panel.SetActive(false);
        }
    }

    public void Update()
    {
        //HideIfClickedOutside(ColourPanel);
        //HideIfClickedOutside(SaturationValue);
        //HideIfClickedOutside(Hue);
    }
}
