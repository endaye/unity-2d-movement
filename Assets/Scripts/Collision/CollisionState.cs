﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionState : MonoBehaviour
{

    public LayerMask collisionLayer;

    public bool standing;
    public Vector2 bottomPosition = Vector2.zero;
    public float collisionRadius = 10f;

	// Use this for initialization
	void Start () {
		
	}

    void FixedUpdate()
    {
        var pos = bottomPosition;
        pos.x += transform.position.x;
        pos.y += transform.position.y;

        standing = Physics2D.OverlapCircle(pos, collisionRadius, collisionLayer);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
