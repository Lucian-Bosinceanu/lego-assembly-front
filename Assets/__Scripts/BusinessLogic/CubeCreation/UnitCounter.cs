using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitCounter : MonoBehaviour {

    public static int count;
    public Text counterText;

    private void Start()
    {
        count = 0;
    }

    private void Update()
    {
        counterText.text = count.ToString();
    }

}
