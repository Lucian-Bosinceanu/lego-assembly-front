using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace InputOutputManager
{
    [Serializable]
    public class OrderElement
    {
        public String   name;
        public Vector3  position;
        public int      rotation;
        public String   color;
    }
}
