﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceDirection : AbstractBehavior
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var right = inputState.GetButtonValue(InputButtons[0]);
        var left = inputState.GetButtonValue(InputButtons[1]);

        if (right)
        {
            inputState.direction = Directions.Right;
        }
        else if (left)
        {
            inputState.direction = Directions.Left;
        }

        transform.localScale = new Vector3((float)inputState.direction, 1f, 1f);
    }
}
