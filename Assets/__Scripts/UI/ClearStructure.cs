using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearStructure : MonoBehaviour {
	public GameObject structure;
	// Use this for initialization
	public void Clear() {
		Destroy(structure);
	}
}
