using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InputOutputManager;

public class DataGatherer : MonoBehaviour
{

    public GameObject anchor;
    private UnitManager unitManager;
    private CubeCollection cubeCollection;
    private Cube cube;
    private OutputWriter outputWriter;

    // Use this for initialization
    public void doIt()
    {
        
        cubeCollection = new CubeCollection();
        outputWriter = new OutputWriter(Application.dataPath + "/test.json");
        unitManager = anchor.GetComponent<UnitManager>();
        foreach (GameObject unit in unitManager.units)
        {
            cube = new Cube();
            cube.x = (int) unit.transform.position.x;
            cube.y = (int) unit.transform.position.y;
            cube.z = (int) unit.transform.position.z;
            //cube.color = new Vector3(unit.GetComponent<Renderer>().material.color.b, unit.GetComponent<Renderer>().material.color.g, unit.GetComponent<Renderer>().material.color.r).ToString();
            cube.color = GetStringFromColor(unit.GetComponent<UnitController>().representation.gameObject.GetComponent<Renderer>().material.color);
            cubeCollection.cubes.Add(cube);
        }
        outputWriter.writeOutput(cubeCollection);
    }

    private string DecToHex(int value)
    {
        return value.ToString("X2");
    }
    
    private string FloatNormalizedToHex(float value)
    {
        return DecToHex(Mathf.RoundToInt(value * 255f));
    }

    private string GetStringFromColor(Color color)
    {
        string red = FloatNormalizedToHex(color.r);
        string green = FloatNormalizedToHex(color.g);
        string blue = FloatNormalizedToHex(color.b);
        return "#" + red + green + blue;
    }
}
