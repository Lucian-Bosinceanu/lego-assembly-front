using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InputOutputManager;
using UnityEngine.UI;
using System;
using System.Diagnostics;
using System.ComponentModel;
using System.IO;
using System.Threading;

public class DataGatherer : MonoBehaviour
{

    public GameObject anchor;
    public GameObject importJsonButton;
    private UnitManager unitManager;
    private CubeCollection cubeCollection;
    private Cube cube;
    private OutputWriter outputWriter;

    public void callBackEnd()
    {
        //export shape to json
        string path = Application.dataPath + "/exportToBack.json";
        outputWriter = new OutputWriter(path);
        outputWriter.writeOutput(doIt());

        //prepare back-end
        //daca rulezi din unity foloseste "/../../lego-assembly-back/main.py"
        string progToRun = Application.dataPath + "/../../lego-assembly-back/main.py";
        Process proc = new Process();
        proc.StartInfo.FileName = "python.exe";
        proc.StartInfo.UseShellExecute = false;
        proc.StartInfo.Arguments = path;
        proc.Start();
        proc.WaitForExit();

        //import json
        //daca rulezi din unity foloseste "/../../lego-assembly-back/JsonOutput.json"
        string contents = File.ReadAllText(Application.dataPath + "/../../lego-assembly-back/JsonOutput.json");
        importJsonButton.GetComponent<InputLoader>().inputCollection = JsonUtility.FromJson<InputCollection>(contents);

    }

    public void export()
    {
        outputWriter = new OutputWriter(importJsonButton.GetComponent<InputLoader>().pathToJson.text);
        outputWriter.writeOutput(doIt());
    }

    // Use this for initialization
    private CubeCollection doIt()
    {
        cubeCollection = new CubeCollection();
        unitManager = anchor.GetComponent<UnitManager>();
        foreach (GameObject unit in unitManager.units)
        {
            cube = new Cube();
            cube.x = (int)unit.transform.position.x;
            cube.y = (int)unit.transform.position.y;
            cube.z = (int)unit.transform.position.z;
            //cube.color = new Vector3(unit.GetComponent<Renderer>().material.color.b, unit.GetComponent<Renderer>().material.color.g, unit.GetComponent<Renderer>().material.color.r).ToString();
            cube.color = GetStringFromColor(unit.GetComponent<UnitController>().representation.gameObject.GetComponent<Renderer>().material.color);
            cubeCollection.cubes.Add(cube);
        }
        return cubeCollection;

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
