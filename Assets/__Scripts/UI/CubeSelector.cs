using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSelector : MonoBehaviour
{
    public static bool selected;
    public GameObject cube;
    public static Renderer rend; 

    public void Start()
    {
        selected = true;
        rend = cube.GetComponent<Renderer>();
    }

    void OnMouseDown()
    {
        selected = !selected;
        AssignColorToCube();
    }

    public static void AssignColorToCube()
    {
        //TODO: do this for all cubes
        if (selected)
        {
            Color color = CUIColorPicker._color;
            rend.material.SetColor("_Color", color);
        }
    }
}
