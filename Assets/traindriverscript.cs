using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class traindriverscript : MonoBehaviour {
	public float notch;
	public Rigidbody rb;
	public float speed;
	public float notchA;
	public Text shownotch;//ノッチ表示用
	public Text showbrake;//ノッチ表示用

	public float moveForceMultiplier;
	// Use this for initialization
	void Start () {
		rb = GameObject.Find("driver").GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		//動かす
		if (Input.GetKeyDown (KeyCode.X)) {
			if ((notch <= 5) && (notch >= 0)) {
				notch += 1;
			}
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			if ((notch <= 0) && (notch >= -8)) {
				notch -= 1;
			}
		}
		//動かす

		//表示

		if (notch == 0) {
			shownotch.text = "切";
			shownotch.ToString();
		}
		if (notch == -8) {
			shownotch.text = "EB";
			shownotch.ToString();
		}
		shownotch.text = notch.ToString ();
		//表示

		//スピードを測る
		speed = rb.velocity.magnitude;
		//スピードを測る



		Debug.Log (notch);
		notchA = notch * 0.025f;
	}
	void FixedUpdate() {
		rb.AddForce (notchA * Vector3.right, ForceMode.Acceleration);
		if (rb.velocity.x < 0) {
			rb.velocity = new Vector3( 0, rb.velocity.y, rb.velocity.z);
		}
	}
}
