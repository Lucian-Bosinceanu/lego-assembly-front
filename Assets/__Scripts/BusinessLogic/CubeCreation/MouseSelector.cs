using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSelector : MonoBehaviour {

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                ClickSelectable selectable = hit.transform.gameObject.GetComponent<ClickSelectable>();
                if (selectable != null) {
                    selectable.leftClickSelect();
                }
            }
        } else if(Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                ClickSelectable selectable = hit.transform.gameObject.GetComponent<ClickSelectable>();
                if (selectable != null)
                {
                    selectable.rightClickSelect();
                }
            }
        }
    }
}
