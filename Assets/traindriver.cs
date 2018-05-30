using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traindriver : MonoBehaviour {
	float speed = 0;
	float power = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update (){
		
		if (Input.GetKeyDown (KeyCode.X)) {
			power += 0.001f;
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			power = 0.0000f;
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			power -= 0.005f;
		}
		if (power >= 0.005f) {
			power = 0.005f;
		}
		if (power <= -0.04f) {
			power = -0.04f;
		}
		if (speed == 0) {
			transform.position += new Vector3 (0, 0, 0);
		}
		speed += power;
		transform.position += new Vector3 (speed * Time.deltaTime, 0, 0);
	}
}
