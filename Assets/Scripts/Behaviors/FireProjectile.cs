using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : AbstractBehavior
{
    public float shootDelay = .5f;
    public GameObject projectilePrefab;

    private float timeElapsed = 0f;

	// Update is called once per frame
	void Update () {
	    if (projectilePrefab != null)
	    {
	        var canFire = inputState.GetButtonValue(InputButtons[0]);
	        if (canFire && timeElapsed > shootDelay)
	        {
                CreateProjectile(transform.position);
	            timeElapsed = 0f;
	        }

	        timeElapsed += Time.deltaTime;
	    }
	}

    public void CreateProjectile(Vector2 pos)
    {
        var clone = Instantiate(projectilePrefab, pos, Quaternion.identity) as GameObject;
        clone.transform.localScale = transform.localScale;
    }
}
