using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class FileExplorerScript : MonoBehaviour
{
    public InputField pathToJson;

    public void OpenExplorer()
    {
        pathToJson.text = EditorUtility.OpenFilePanel("Overwrite with json", "", "json");
    }

    public void ImportJson()
    {
        if (pathToJson.text != null)
        {
            string dataAsJson = File.ReadAllText(pathToJson.text);

            //TODO: remove line below and use dataAsJson to import structure object
            EditorUtility.DisplayDialog("Your json:", dataAsJson, "Ok");
        }
    }
}
