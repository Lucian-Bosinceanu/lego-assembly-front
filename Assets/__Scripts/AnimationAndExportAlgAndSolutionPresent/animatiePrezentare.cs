using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatiePrezentare : MonoBehaviour
{

    int i;
    int n;//lngimea vectorului 3
    public Vector3[] coord = new Vector3[20];
    // Use this for initialization
    IEnumerator Start()
    {
       
        Camera camera = GetComponent<Camera>();

        for (i = 0; i < n; i++)
        {
            yield return new WaitForSeconds(2);
            camera.transform.position = new Vector3(coord[i].x, coord[i].y + 1, coord[i].z - 7);
            cub(coord[i].x, coord[i].y, coord[i].z);
        }
        
    }

    void cub(float x, float y, float z)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(x, y, z);
        cube.AddComponent<Rigidbody>();
    }

    void Update()
    {
        
    }
}