﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    private InputState inputState;
    private Walk walkBehavior;
    private Animator animator;

    void Awake()
    {
        inputState = GetComponent<InputState>();
        walkBehavior = GetComponent<Walk>();
        animator = GetComponent<Animator>();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (inputState.absVelX == 0)
        {
            ChangeAnimationState(0);
        }

        if (inputState.absVelX > 0)
        {
            ChangeAnimationState(1);
        }

        animator.speed = walkBehavior.running ? walkBehavior.runMutiplier : 1f;
    }

    void ChangeAnimationState(int value)
    {
        animator.SetInteger("AnimState", value);
    }
}