using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface ISelectableDelegate {
    void DidSelect(ClickSelectable selectable);
    void LeftSelect(ClickSelectable selectable);
}

public class ClickSelectable : MonoBehaviour {
    public ISelectableDelegate selectableDelegate;
	
    public void select() {
        if (selectableDelegate != null) {
            selectableDelegate.DidSelect(this);
        }
    }

    public void leftSelect()
    {
        if (selectableDelegate != null)
        {
            selectableDelegate.LeftSelect(this);
        }
    }
}
