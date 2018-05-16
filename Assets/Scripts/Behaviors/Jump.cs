using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : AbstractBehavior
{

    public float jumpSpeed = 200f;
    public float jumpDelay = .1f;
    public int jumpCount = 2;

    protected float lastJumpTime = 0;
    protected int jumpRemaining = 0;

    // Update is called once per frame
    void Update()
    {
        var canJump = inputState.GetButtonValue(InputButtons[0]);
        var holdTime = inputState.GetButtonHoldTime(InputButtons[0]);
        if (collisionState.standing)
        {
            if (canJump && holdTime < .1f)
            {
                jumpRemaining = jumpCount - 1;
                OnJump();
            }
        }
        else
        {
            if (canJump && holdTime < .1f && Time.time - lastJumpTime > jumpDelay && jumpRemaining > 0)
            {
                OnJump();
                jumpRemaining--;
            }
        }
    }

    protected virtual void OnJump()
    {
        var vel = body2d.velocity;
        lastJumpTime = Time.time;
        body2d.velocity = new Vector2(vel.x, jumpSpeed);
    }
}
