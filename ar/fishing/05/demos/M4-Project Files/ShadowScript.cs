using UnityEngine;
using System.Collections;

public class ShadowScript : MonoBehaviour {
	//Makes window for object to follow and renames it to myParent
	public GameObject myParent;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// set the x and y to match myParent and set Y to 0
		transform.position = new Vector3 (myParent.transform.position.x, 0, myParent.transform.position.z);	
	}
}
