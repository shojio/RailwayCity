using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traindriverscript : MonoBehaviour {
	public float notch;
	public Rigidbody rb;
	public float position;
	public float notchA;
	public int brake;
	public string shownotch;//ノッチ表示用

	public float moveForceMultiplier;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.X)) {
			if (notch <= 4.5f) {
				notch += 1;
			}
		}
		if (notch >= -8.5f) {
			if (Input.GetKeyDown (KeyCode.W)) {
				notch -= 1;
			}
		}
		//ここから表示用
		if ((notch <= 0) && (brake <= 8)) {
			brake += 1;
		}
		if (notch == 0) {
			shownotch = "切";
		}
		if (notch < 0) {
			shownotch = brake.ToString ();
			if (brake == 8) {
				shownotch = "EB";
			}
		}
		if (notch > 0) {
			shownotch = notch.ToString ();
		}
		//ここまで表示用
		position = transform.position.x;
		Debug.Log (position);
		notchA = 0.005f * notch;
		Debug.Log (notch);

	}
	void FixedUpdate() {
		rb.AddForce (notchA, 0, 0, ForceMode.Force);
	}
}
