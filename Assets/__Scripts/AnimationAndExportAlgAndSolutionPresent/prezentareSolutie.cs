using System.Collections;
using UnityEngine;

public class prezentareSolutie : MonoBehaviour
{
    /// <summary>
    /// ok=1 pentru forward speed=1
    /// ok=2 pentru cazut cuburi normal speed=2
    /// ok=3 pentru toend speed=0
    /// </summary>
    int ok = 3;
    int speed = 0;
    int i;
    int n;//lngimea vectorului 3
    public Vector3[] coord = new Vector3[20];
    // Use this for initialization
    IEnumerator Start(){

        for (i = 0; i < n; i++)
        {

            if (ok == 1)
            {
                speed = 1;
            }

            if (ok == 2)
            {
                speed = 2;
            }

            if (ok == 3)
            {
                speed = 0;
            }

            yield return new WaitForSeconds(speed);
            cub(coord[i].x, coord[i].y, coord[i].z);
        }
        
    }
    
    void cub(float x, float y, float z)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(x, y, z);
        cube.AddComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
