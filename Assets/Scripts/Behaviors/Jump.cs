using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : AbstractBehavior
{

    public float jumpSpeed = 200f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    var canJump = inputState.GetButtonValue(InputButtons[0]);

	    if (collisionState.standing)
	    {
	        if (canJump)
	        {
                OnJump();
	        }
	    }
	}

    protected virtual void OnJump()
    {
        var vel = body2d.velocity;

        body2d.velocity = new Vector2(vel.x, jumpSpeed);

    }
}
