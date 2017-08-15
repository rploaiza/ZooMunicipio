using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;

public class move : MonoBehaviour {

	public Animation anim;
	private float speed = 100.0f;
	private float rotationSpeed = 150.0f;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animation> ();
	}

	// Update is called once per frame
	void Update () {
		float x = CrossPlatformInputManager.GetAxis ("Vertical") * rotationSpeed;
		float y = CrossPlatformInputManager.GetAxis ("Horizontal") * speed;

		x *= Time.deltaTime;
		y *= Time.deltaTime;
		transform.Translate (0.0f,0.0f,x);
		transform.Rotate(0.0f,y,0.0f);



		if (x != 0 || y != 0) {
			anim.Play ("walk");
		} else {
			anim.Play ("Take 001");
		}
	}	
}
