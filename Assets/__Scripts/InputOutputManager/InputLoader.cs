using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

namespace InputOutputManager
{
    public class InputLoader : MonoBehaviour
    {
        public InputCollection inputCollection;

        public InputField pathToJson;

        public void OpenExplorer()
        {
            pathToJson.text = EditorUtility.OpenFilePanel("Overwrite with json", "", "json");
        }

        public void loadInput()
        {
            string contents = File.ReadAllText(pathToJson.text);
            this.inputCollection = JsonUtility.FromJson<InputCollection>(contents);
        }
    }
}
