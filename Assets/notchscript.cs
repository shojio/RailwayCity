using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class notchscript : MonoBehaviour {
	public Text shownotch;
	int notch = 0;
	public int brake = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (notch < -8) {
			notch = -8;
		}
		if (notch > 5) {
			notch = 5;
		}
		if (brake > 8) {
			brake = 8;
		}
		if (brake < -5) {
			brake = -5;
		}
		if (Input.GetKeyDown (KeyCode.X)) {
			notch += 1;
			brake -= 1;
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			notch = 0;
			brake = 0;
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			notch -= 1;
			brake += 1;
		}
			
		if (notch == 0) {
			shownotch.text = "切";
		}
		if (notch < 0) {
			shownotch.text = brake.ToString ();
			if (brake == 8) {
				shownotch.text = "EB";
			}
		}
		if (notch > 0) {
			shownotch.text = notch.ToString ();
		}
	}
}
