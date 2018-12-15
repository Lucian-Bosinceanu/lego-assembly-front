using System.Collections;
using System.Collections.Generic;
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
    // Use this for initialization
    IEnumerator Start(){
      
        int x, y, z;
        y = 5; z = -5;
        
    for (x = -4; x <= 4; x = x + 2)
    {
        
        if(ok==1)
            {
                speed = 1;
            }

        if(ok==2)
            {
                speed = 2;
            }

        if(ok==3)
            {
                speed = 0;
            }

        yield return new WaitForSeconds(speed);
        cub(x, y, z);
    }

    }
    
    void cub(int x, int y, int z)
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
