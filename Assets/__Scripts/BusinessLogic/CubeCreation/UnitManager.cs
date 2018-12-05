using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        CreateUnit(newUnitPosition);
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
    }

    public void DestroyUnit(GameObject selected)
    {
        units.Remove(selected);
        Destroy(selected);
    }

}
