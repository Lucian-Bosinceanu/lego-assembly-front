using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Validation;

public interface IUnitManagerDelegate {
    void DidSelectUnitAndArrow(UnitController unit, GameObject creationArrow);
    void FocusUnit(UnitController unit);
    void DestroyUnit(GameObject slected);
}

public class UnitController : MonoBehaviour, ISelectableDelegate {
    public IUnitManagerDelegate manager;

    public GameObject representation;
    public GameObject[] creationArrows;


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

    public void DidSelect(ClickSelectable selectable) {
        if (manager == null) {
            print("MANAGER IS NULL");
            return;
        }
        if (selectable == representation.GetComponent<ClickSelectable>()) {
            manager.FocusUnit(this);
        } else {
            GameObject selected = selectable.gameObject;
            manager.DidSelectUnitAndArrow(this, selected);
        }
    }

    public void LeftSelect(ClickSelectable selectable)
    {
        if (manager == null)
        {
            print("MANAGER IS NULL");
            return;
        }
        if (selectable == representation.GetComponent<ClickSelectable>())
        {
            manager.DestroyUnit(gameObject);
            CallValidator();
        }
        else
        {
            GameObject selected = selectable.gameObject;
            manager.DestroyUnit(selected);
            CallValidator();
        }
    }

    void Start() {
        representation.GetComponent<ClickSelectable>().selectableDelegate = this;
        foreach (GameObject arrow in creationArrows) {
            arrow.GetComponent<ClickSelectable>().selectableDelegate = this;
        }
        HideArrows();
    }

    public void HideArrows() {
        foreach (GameObject arrow in creationArrows) {
            arrow.SetActive(false);
        }
    }

    public void ShowArrows() {
        foreach (GameObject arrow in creationArrows) {
            arrow.SetActive(true);
        }
    }

}
