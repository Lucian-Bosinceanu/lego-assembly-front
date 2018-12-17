using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyColorScript : MonoBehaviour {

    public UnitManager manager;

    public void OnApply() {
        UnitController currentUnit = manager.current;
        if (currentUnit != null) {
            GameObject currentCubeRepresentation = currentUnit.representation.gameObject;
            SetColorForUnit(currentCubeRepresentation);
        }
    }
	
	void SetColorForUnit(GameObject unit) {
        Renderer rend = unit.GetComponent<Renderer>();
        Color color = CUIColorPicker._color;
        rend.material.SetColor("_Color", color);
    }
}
