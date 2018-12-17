using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface ISelectableDelegate {
    void DidSelect(ClickSelectable selectable);
    void LeftSelect(ClickSelectable selectable);
}

public class ClickSelectable : MonoBehaviour {
    public ISelectableDelegate selectableDelegate;

    public bool rightClickable;
    public bool leftClickable;
	
    public void leftClickSelect() {
        if (selectableDelegate != null && leftClickable) {
            selectableDelegate.DidSelect(this);
        }
    }

    public void rightClickSelect()
    {
        if (selectableDelegate != null && rightClickable)
        {
            selectableDelegate.LeftSelect(this);
        }
    }
}
