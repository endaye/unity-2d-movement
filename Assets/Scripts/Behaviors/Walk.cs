using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : AbstractBehavior
{

    public float speed = 50f;
    public float runMutiplier = 2f;
    public bool running;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        running = false;

        var right = inputState.GetButtonValue(InputButtons[0]);
        var left = inputState.GetButtonValue(InputButtons[1]);
        var run = inputState.GetButtonValue(InputButtons[2]);

        if (right || left)
        {
            var tmpSpeed = speed;
            if (run && runMutiplier > 0)
            {
                tmpSpeed *= runMutiplier;
                running = true;
            }
            var velX = tmpSpeed * (float)inputState.direction;
            body2d.velocity = new Vector2(velX, body2d.velocity.y);
        }
    }
}
