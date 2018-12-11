﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class UnitManager : MonoBehaviour, IUnitManagerDelegate {
    public GameObject UnitPrefab;
    public GameObject SculptureAnchor;

    public UnitController current;

    public ArrayList units;

    public void FocusUnit(UnitController unit) {
        if (current != null) {
            current.HideArrows();
        }
        current = unit;
        unit.ShowArrows();
    }

    public void DidSelectUnitAndArrow(UnitController unit, GameObject creationArrow) {
        Vector3 distance = (unit.representation.transform.position - creationArrow.transform.position) * 2;
        Vector3 newUnitPosition = unit.transform.position - distance;
        if (UnitCounter.count == UnitCounter.MAX_NUMBER_OF_CUBES)
        {
            EditorUtility.DisplayDialog("Cube limit reached", "Cannot add more cubes! " +
                "The maximum number of cubes permitted is 5000.", "Ok");
        }
        else
        {
            CreateUnit(newUnitPosition);
        }
    }

    // Use this for initialization
    void Start () {
        units = new ArrayList();
        CreateUnit(Vector3.zero);
	}
	
	
    void CreateUnit(Vector3 position) {
        GameObject newUnit = Instantiate(UnitPrefab, SculptureAnchor.transform, true);
        newUnit.transform.position = position;
        newUnit.SetActive(true);
        newUnit.GetComponent<UnitController>().manager = this;
        units.Add(newUnit);
        UnitCounter.count++;
    }

    public void DestroyUnit(GameObject selected)
    {
        units.Remove(selected);
        UnitCounter.count--;
        Destroy(selected);
    }

}
