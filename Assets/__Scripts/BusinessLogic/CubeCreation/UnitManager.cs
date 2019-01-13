using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
using Validation;
using UnityEngine.UI;

public class UnitManager : MonoBehaviour, IUnitManagerDelegate
{
    public GameObject UnitPrefab;
    public GameObject SculptureAnchor;

    public UnitController current;

    public ArrayList units;

    public bool IsFirstCube;

    public void CallValidator()
    {
        Validator Sculpture = new Validator();

        GameObject cube;
        GameObject[] cubes;

        cube = GameObject.FindGameObjectWithTag("OriginCube");
        cubes = GameObject.FindGameObjectsWithTag("Cube");
        Sculpture.SetOrigin(cube);
        Sculpture.ConvertList(cubes);
        Sculpture.Start();
    }

    public void FocusUnit(UnitController unit)
    {
        if (current != null)
        {
            current.HideArrows();
        }
        current = unit;
        unit.ShowArrows();
    }

    public void DidSelectUnitAndArrow(UnitController unit, GameObject creationArrow)
    {
        Vector3 distance = (unit.representation.transform.position - creationArrow.transform.position) * 2;
        Vector3 newUnitPosition = unit.transform.position - distance;
        if (UnitCounter.count == UnitCounter.MAX_NUMBER_OF_CUBES)
        {
#if UNITY_EDITOR
            EditorUtility.DisplayDialog("Cube limit reached", "Cannot add more cubes! " +
                "The maximum number of cubes permitted is 5000.", "Ok");
#endif
        }
        else
        {
            CreateUnit(newUnitPosition);
        }
    }

    // Use this for initialization
    void Start()
    {
        units = new ArrayList();
        IsFirstCube = true;
        CreateUnit(Vector3.zero);
    }


    void CreateUnit(Vector3 position)
    {
        GameObject newUnit = Instantiate(UnitPrefab, SculptureAnchor.transform, true);
        newUnit.transform.position = position;
        newUnit.SetActive(true);
        if (IsFirstCube)
        {
            newUnit.GetComponent<UnitController>().representation.tag = "OriginCube";
            IsFirstCube = false;
        }
        else
        {
            newUnit.GetComponent<UnitController>().representation.tag = "Cube";
        }
        newUnit.GetComponent<UnitController>().manager = this;
        units.Add(newUnit);
        UnitCounter.count++;
        CallValidator();
    }

    public void DestroyUnit(GameObject selected)
    {
        units.Remove(selected);
        UnitCounter.count--;
        Destroy(selected);
        selected.GetComponent<UnitController>().representation.tag = "Untagged";
        CallValidator();
    }

}
