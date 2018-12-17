using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitCounter : MonoBehaviour {

    public static int count;
    public const int MAX_NUMBER_OF_CUBES = 50;
    public Text counterText;

    private void Start()
    {
        count = 1;
    }

    private void Update()
    {
        counterText.text = count.ToString();
    }

}
