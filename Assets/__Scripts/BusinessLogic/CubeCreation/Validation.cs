using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Validation
{
    class Validator
    {
        public List<GameObject> BadCubes;
        public List<GameObject> AllCubes;
        public GameObject OriginCube;

        public Validator()
        {
            BadCubes = new List<GameObject>();
            AllCubes = new List<GameObject>();
        }

        public void ConvertList(GameObject[] InputList)
        {
            foreach(GameObject cube in InputList)
            {
                AllCubes.Add(cube);
            }
        }

        public void SetOrigin(GameObject origincube)
        {
            OriginCube = origincube;
        }

        public void Start()
        {
            //First we need to see neighbours right near origin
            List<GameObject> CheckedCubes = new List<GameObject>();
            CheckedCubes.Add(OriginCube);
            OriginCube.GetComponent<Renderer>().material.color = Color.green;
            foreach (GameObject cube in AllCubes)
            {
                Renderer Origin, CubeToCheck;
                Origin = OriginCube.GetComponent<Renderer>();
                CubeToCheck = cube.GetComponent<Renderer>();
                float distance;
                distance = Vector3.Distance(Origin.transform.position, CubeToCheck.transform.position);
                if(distance == 1)
                {
                    if (!CheckedCubes.Contains(cube))
                    {
                        CheckedCubes.Add(cube);
                        CubeToCheck.material.color = Color.green;
                        Debug.Log("Origin has one niegh");
                    }
                    
                }
            }

            int NumberOfCubes = AllCubes.Count + 1;

            foreach(GameObject cube in CheckedCubes)
            {
                if (AllCubes.Contains(cube))
                {
                    AllCubes.Remove(cube);
                }
            }

            int counter = 1;

            while(counter < NumberOfCubes && counter < CheckedCubes.Count)
            {
                Continue(CheckedCubes, counter);
                counter++;
            }

            foreach(GameObject cube in AllCubes)
            {
                Renderer rend;
                rend = cube.GetComponent<Renderer>();
                rend.material.color = Color.red;
            }
        }

        public void Continue(List<GameObject> CheckedCubes, int counter)
        {
            Renderer Origin;
            Origin = CheckedCubes[counter].GetComponent<Renderer>();
            foreach(GameObject cube in AllCubes)
            {
                Renderer CubeToCheck;

                CubeToCheck = cube.GetComponent<Renderer>();
                float distance;
                distance = Vector3.Distance(Origin.transform.position, CubeToCheck.transform.position);
                if (distance == 1)
                {
                    if (!CheckedCubes.Contains(cube))
                    {
                        CheckedCubes.Add(cube);
                        CubeToCheck.material.color = Color.green;
                        Debug.Log("Origin has one niegh");
                    }

                }
            }

            foreach (GameObject cube in CheckedCubes)
            {
                if (AllCubes.Contains(cube))
                {
                    AllCubes.Remove(cube);
                }
            }
        }

        public List<GameObject> GetResult()
        {
            return AllCubes;
        }
    }
}
