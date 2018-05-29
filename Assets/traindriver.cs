using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traindriver : MonoBehaviour {
	float speed = 0.01;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.X)) {
			speed++;
			transform.position += new Vector3 (speed * Time.deltaTime, 0, 0);
		}
	}
}
