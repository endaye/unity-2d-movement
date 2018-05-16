using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceDirection : AbstractBehavior {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var right = inputState.GetButtonValue (InputButtons [0]);
		var left = inputState.GetButtonValue (InputButtons [1]);

		if (right) {
			Debug.Log ("Facing Right");
		} else if (left) {
			Debug.Log ("Facing Left");
		}
	}
}
