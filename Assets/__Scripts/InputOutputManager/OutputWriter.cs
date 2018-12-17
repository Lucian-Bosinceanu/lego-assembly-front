using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using UnityEngine;

namespace InputOutputManager
{
    class OutputWriter
    {
        private String filePath;

        public OutputWriter(String filePath)
        {
            this.filePath = filePath;
        }

        public void writeOutput(CubeCollection cubeCollection)
        {
            string contents = JsonUtility.ToJson(cubeCollection);
            File.WriteAllText(filePath, contents);
        }
    }
}
