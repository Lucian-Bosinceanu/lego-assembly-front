using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace InputOutputManager
{
    public class InputLoader : MonoBehaviour
    {
        public InputCollection inputCollection;

        public InputField pathToJson;

        public void OpenExplorer()
        {
#if UNITY_EDITOR
            pathToJson.text = EditorUtility.OpenFilePanel("Overwrite with json", "", "json");
#endif
        }

        public void loadInput()
        {
            string contents = File.ReadAllText(pathToJson.text);
            this.inputCollection = JsonUtility.FromJson<InputCollection>(contents);
        }
    }
}
