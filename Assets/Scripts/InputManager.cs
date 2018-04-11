using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Buttons
{
    Right,
    Left,
}

[System.Serializable]
public class InputAxisState
{
    public string axisName;
    public float offValue;
    public Buttons botton;
}

public class InputManager : MonoBehaviour
{

    public InputAxisState[] inputs;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
