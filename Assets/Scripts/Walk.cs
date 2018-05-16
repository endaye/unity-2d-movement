using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : AbstractBehavior {

	public float speed = 50f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var right = inputState.GetButtonValue (InputButtons [0]);
		var left = inputState.GetButtonValue (InputButtons [1]);

		if (right || left) {
			var tmpSpeed = speed;
			var velX = tmpSpeed * (float)inputState.direction;
			body2d.velocity = new Vector2 (velX, body2d.velocity.y);
		}
	}
}
