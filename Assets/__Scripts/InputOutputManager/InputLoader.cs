using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEngine;

namespace InputOutputManager
{
    class InputLoader
    {
        private String filePath;

        public InputLoader(String filePath)
        {
            this.filePath = filePath;
        }

        public InputCollection loadInput()
        {
            string contents = File.ReadAllText(filePath);
            return JsonUtility.FromJson<InputCollection>(contents);
        }
    }
}
