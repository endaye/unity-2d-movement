﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equip : AbstractBehavior {

    private int _currentItem = 0;
    private Animator animator;

    public int currentItem
    {
        get { return _currentItem; }
        set {
            _currentItem = value;
            animator.SetInteger("EquippedItem", _currentItem);
        }
    }

    override protected void Awake()
    {
        base.Awake();
        animator = GetComponent<Animator>();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
