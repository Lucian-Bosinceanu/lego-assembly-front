using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InputOutputManager;

public class animatiePrezentare : MonoBehaviour
{
    public GameObject importButton;
    private InputCollection inputCollection;
    public int button;
    int i,speed;
    public Vector3[] coord = new Vector3[5000];
    // Use this for initialization
 

    public void PrezentareSolutie()
    {
        SpawnCubes();
        speed = 2;
    }

    public void ChangeSpeedToEnd()
    {
        speed = 0;
    }

    public void ChangeSpeedToFast()
    {
        speed = 1;
    }

    //public void changespeedtonormal()
    //{
    //    speed = 2;
    //}


    public void SpawnCubes()
    {
        inputCollection = importButton.GetComponent<InputLoader>().inputCollection;
        Debug.Log("asd");
        for (i=1;i<=5000;i++)
            {

            //Camera camera = GetComponent<Camera>();

            StartCoroutine(MyCoroutine());

            //camera.transform.position = new Vector3(inputCollection.order[i].position.x,inputCollection.order[i].position.y + 1, inputCollection.order[i].position.z - 7);//mutare camera pe cubul care trebuie as apara

            if (inputCollection.order[i].name == "1x1")
            {
                cub1x1(inputCollection.order[i].position.x, inputCollection.order[i].position.y, inputCollection.order[i].position.z, inputCollection.order[i].rotation);//crearea cubului
            }

            if (inputCollection.order[i].name == "1x2")
            {
                cub1x2(inputCollection.order[i].position.x, inputCollection.order[i].position.y, inputCollection.order[i].position.z, inputCollection.order[i].rotation);//crearea cubului
            }

            if (inputCollection.order[i].name == "1x3")
            {
                cub1x3(inputCollection.order[i].position.x, inputCollection.order[i].position.y, inputCollection.order[i].position.z, inputCollection.order[i].rotation);//crearea cubului
            }

            if (inputCollection.order[i].name == "1x4")
            {
                cub1x4(inputCollection.order[i].position.x, inputCollection.order[i].position.y, inputCollection.order[i].position.z, inputCollection.order[i].rotation);//crearea cubului
            }

            if (inputCollection.order[i].name == "2x2")
            {
                cub2x2(inputCollection.order[i].position.x, inputCollection.order[i].position.y, inputCollection.order[i].position.z, inputCollection.order[i].rotation);//crearea cubului
            }

            if (inputCollection.order[i].name == "2x3")
            {
                cub2x3(inputCollection.order[i].position.x, inputCollection.order[i].position.y, inputCollection.order[i].position.z, inputCollection.order[i].rotation);//crearea cubului
            }

            if (inputCollection.order[i].name == "2x4")
            {
                cub2x4(inputCollection.order[i].position.x, inputCollection.order[i].position.y, inputCollection.order[i].position.z, inputCollection.order[i].rotation);//crearea cubului
            }

        }

    }

    IEnumerator MyCoroutine()
    {
        yield return new WaitForSeconds(speed);
    }

    //functiile pentru crearea cuburilor pe dimensiuni

    void cub1x1(float x, float y, float z,int rotation)
    {
        GameObject cube1x1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube1x1.transform.position = new Vector3(x, y + 20, z);
        cube1x1.transform.Rotate(cube1x1.transform.eulerAngles.x, cube1x1.transform.eulerAngles.y-rotation, cube1x1.transform.eulerAngles.z);
        //cube1x1.material.color = Color.blue;
        cube1x1.AddComponent<Rigidbody>();
    } 

    void cub1x2(float x, float y, float z, int rotation)
    {
        GameObject cube1x2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube1x2.transform.position = new Vector3(x, y+20, z);
        cube1x2.transform.Rotate(cube1x2.transform.eulerAngles.x, cube1x2.transform.eulerAngles.y - rotation, cube1x2.transform.eulerAngles.z);
        cube1x2.transform.localScale = new Vector3(cube1x2.transform.localScale.x*2, cube1x2.transform.localScale.y, cube1x2.transform.localScale.z);//modificarea cubului standard pentru 
        cube1x2.AddComponent<Rigidbody>();
    }

    void cub1x3(float x, float y, float z, int rotation)
    {
        GameObject cube1x3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube1x3.transform.position = new Vector3(x, y + 20, z);
        cube1x3.transform.Rotate(cube1x3.transform.eulerAngles.x, cube1x3.transform.eulerAngles.y - rotation, cube1x3.transform.eulerAngles.z);
        cube1x3.transform.localScale = new Vector3(cube1x3.transform.localScale.x * 3, cube1x3.transform.localScale.y, cube1x3.transform.localScale.z);
        cube1x3.AddComponent<Rigidbody>();
    }

    void cub1x4(float x, float y, float z, int rotation)
    {
        GameObject cube1x4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube1x4.transform.position = new Vector3(x, y + 20, z);
        cube1x4.transform.Rotate(cube1x4.transform.eulerAngles.x, cube1x4.transform.eulerAngles.y - rotation, cube1x4.transform.eulerAngles.z);
        cube1x4.transform.localScale = new Vector3(cube1x4.transform.localScale.x * 4, cube1x4.transform.localScale.y, cube1x4.transform.localScale.z);
        cube1x4.AddComponent<Rigidbody>();
    }

    void cub2x2(float x, float y, float z, int rotation)
    {
        GameObject cube2x2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube2x2.transform.position = new Vector3(x, y + 20, z);
        cube2x2.transform.Rotate(cube2x2.transform.eulerAngles.x, cube2x2.transform.eulerAngles.y - rotation, cube2x2.transform.eulerAngles.z);
        cube2x2.transform.localScale = new Vector3(cube2x2.transform.localScale.x * 2, cube2x2.transform.localScale.y *2 , cube2x2.transform.localScale.z);
        cube2x2.AddComponent<Rigidbody>();
    }

    void cub2x3(float x, float y, float z, int rotation)
    {
        GameObject cube2x3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube2x3.transform.position = new Vector3(x, y + 20, z);
        cube2x3.transform.Rotate(cube2x3.transform.eulerAngles.x, cube2x3.transform.eulerAngles.y - rotation, cube2x3.transform.eulerAngles.z);
        cube2x3.transform.localScale = new Vector3(cube2x3.transform.localScale.x * 3, cube2x3.transform.localScale.y * 2, cube2x3.transform.localScale.z);
        cube2x3.AddComponent<Rigidbody>();
        cube2x3.GetComponent<Renderer>().material.color = new Color(4, 5, 2, 1);
        
    }

    void cub2x4(float x, float y, float z, int rotation)
    {
        GameObject cube2x4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube2x4.transform.position = new Vector3(x, y + 20, z);
        cube2x4.transform.Rotate(cube2x4.transform.eulerAngles.x, cube2x4.transform.eulerAngles.y - rotation, cube2x4.transform.eulerAngles.z);
        cube2x4.transform.localScale = new Vector3(cube2x4.transform.localScale.x * 4, cube2x4.transform.localScale.y * 2, cube2x4.transform.localScale.z);
        cube2x4.AddComponent<Rigidbody>();
    }


    void Update()
    {
        
    }
}