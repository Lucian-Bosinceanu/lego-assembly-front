using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine.UI;

public class FileExplorerScript : MonoBehaviour
{
    public InputField pathToJson;

    public void OpenExplorer()
    {
#if UNITY_EDITOR
        pathToJson.text = EditorUtility.OpenFilePanel("Overwrite with json", "", "json");
#endif
    }

    public void ImportJson()
    {
        if (pathToJson.text != null)
        {
            string dataAsJson = File.ReadAllText(pathToJson.text);
#if UNITY_EDITOR
            //TODO: remove line below and use dataAsJson to import structure object
            EditorUtility.DisplayDialog("Your json:", dataAsJson, "Ok");
#endif
        }
    }
}
