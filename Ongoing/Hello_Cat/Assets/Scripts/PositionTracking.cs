using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionTracking : MonoBehaviour {

    public GameObject TextObject;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        TextObject.GetComponent<TextMesh>().text = "Pos: " + this.transform.position;
	}
}
