using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InputOutputManager;

public class animatiePrezentare : MonoBehaviour
{
    public GameObject importButton;
    private InputCollection inputCollection;
    public int button;
    int i;
    float speed;
    public Vector3[] coord = new Vector3[5000];


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
    public void spawn()
    {

    }

    public void SpawnCubes()
    {

        speed = 2;
        StartCoroutine(asd());
        
    }

    IEnumerator asd()
    {
        inputCollection = importButton.GetComponent<InputLoader>().inputCollection;
        for (i = 1; i <= 5000; i++)
        {
        Debug.Log("wait_on");
        yield return new WaitForSeconds(speed);
        Debug.Log("wait_off");

        if (inputCollection.order[i].name == "1x1")
        {
            Debug.Log("spawned 1x1");
            cub1x1(inputCollection.order[i].position.x, inputCollection.order[i].position.y, inputCollection.order[i].position.z, inputCollection.order[i].rotation);//crearea cubului
        }

        if (inputCollection.order[i].name == "1x2")
        {
            Debug.Log("spawned 1x2");
            cub1x2(inputCollection.order[i].position.x, inputCollection.order[i].position.y, inputCollection.order[i].position.z, inputCollection.order[i].rotation);//crearea cubului
        }

        if (inputCollection.order[i].name == "1x3")
        {
            Debug.Log("spawned 1x3");
            cub1x3(inputCollection.order[i].position.x, inputCollection.order[i].position.y, inputCollection.order[i].position.z, inputCollection.order[i].rotation);//crearea cubului
        }

        if (inputCollection.order[i].name == "1x4")
        {
            Debug.Log("spawned 1x4");
            cub1x4(inputCollection.order[i].position.x, inputCollection.order[i].position.y, inputCollection.order[i].position.z, inputCollection.order[i].rotation);//crearea cubului
        }

        if (inputCollection.order[i].name == "2x2")
        {
            Debug.Log("spawned 2x2");
            cub2x2(inputCollection.order[i].position.x, inputCollection.order[i].position.y, inputCollection.order[i].position.z, inputCollection.order[i].rotation);//crearea cubului
        }

        if (inputCollection.order[i].name == "2x3")
        {
            Debug.Log("spawned 2x3");
            cub2x3(inputCollection.order[i].position.x, inputCollection.order[i].position.y, inputCollection.order[i].position.z, inputCollection.order[i].rotation);//crearea cubului
        }

        if (inputCollection.order[i].name == "2x4")
        {
            Debug.Log("spawned 2x4");
            cub2x4(inputCollection.order[i].position.x, inputCollection.order[i].position.y, inputCollection.order[i].position.z, inputCollection.order[i].rotation);//crearea cubului
        }
    }
    }

    //functiile pentru crearea cuburilor pe dimensiuni

    void cub1x1(float x, float y, float z, int rotation)
    {
        GameObject cube1x1 = Instantiate(GameObject.Find("Cubes/1x1"));
        cube1x1.transform.position = new Vector3(x, y + 20, z);
        cube1x1.transform.Rotate(cube1x1.transform.eulerAngles.x, cube1x1.transform.eulerAngles.y - rotation, cube1x1.transform.eulerAngles.z);

    }

    void cub1x2(float x, float y, float z, int rotation)
    {
        GameObject cube1x2 = Instantiate(GameObject.Find("Cubes/1x2"));
        cube1x2.transform.position = new Vector3(x, y + 20, z);
        cube1x2.transform.Rotate(cube1x2.transform.eulerAngles.x, cube1x2.transform.eulerAngles.y - rotation, cube1x2.transform.eulerAngles.z);
        
    }

    void cub1x3(float x, float y, float z, int rotation)
    {
        GameObject cube1x3 = Instantiate(GameObject.Find("Cubes/1x3"));
        cube1x3.transform.position = new Vector3(x, y + 20, z);
        cube1x3.transform.Rotate(cube1x3.transform.eulerAngles.x, cube1x3.transform.eulerAngles.y - rotation, cube1x3.transform.eulerAngles.z);

    }

    void cub1x4(float x, float y, float z, int rotation)
    {
        GameObject cube1x4 = Instantiate(GameObject.Find("Cubes/1x4"));
        cube1x4.transform.position = new Vector3(x, y + 20, z);
        cube1x4.transform.Rotate(cube1x4.transform.eulerAngles.x, cube1x4.transform.eulerAngles.y - rotation, cube1x4.transform.eulerAngles.z);

    }

    void cub2x2(float x, float y, float z, int rotation)
    {
        GameObject cube2x2 = Instantiate(GameObject.Find("Cubes/2x2"));
        cube2x2.transform.position = new Vector3(x, y + 20, z);
        cube2x2.transform.Rotate(cube2x2.transform.eulerAngles.x, cube2x2.transform.eulerAngles.y - rotation, cube2x2.transform.eulerAngles.z);

    }

    void cub2x3(float x, float y, float z, int rotation)
    {
        GameObject cube2x3 = Instantiate(GameObject.Find("Cubes/2x3"));
        cube2x3.transform.position = new Vector3(x, y + 20, z);
        cube2x3.transform.Rotate(cube2x3.transform.eulerAngles.x, cube2x3.transform.eulerAngles.y - rotation, cube2x3.transform.eulerAngles.z);
        cube2x3.GetComponent<Renderer>().material.color = new Color(4, 5, 2, 1);

    }

    void cub2x4(float x, float y, float z, int rotation)
    {
        GameObject cube2x4 = Instantiate(GameObject.Find("Cubes/2x4"));
        cube2x4.transform.position = new Vector3(x, y + 20, z);
        cube2x4.transform.Rotate(cube2x4.transform.eulerAngles.x, cube2x4.transform.eulerAngles.y - rotation, cube2x4.transform.eulerAngles.z);

    }


    void Update()
    {

    }

}