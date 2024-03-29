﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour {

    public Vector2 InitialVelVector2 = new Vector2(100f, -100f);
    public int bounces = 3;

    private Rigidbody2D body2d;

    void Awake()
    {
        body2d = GetComponent<Rigidbody2D>();
    }

	// Use this for initialization
	void Start ()
	{
	    var startVelX = InitialVelVector2.x * transform.localScale.x;
        body2d.velocity = new Vector2(startVelX, InitialVelVector2.y);
	}

    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.transform.position.y < transform.position.y)
        {
            bounces--;
        }

        if (bounces <= 0)
        {
            Destroy(gameObject);
        }
    }
}
