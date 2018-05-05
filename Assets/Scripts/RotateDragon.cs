using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDragon : MonoBehaviour {

	public float MaxDownVelocity = -7.5f;
	public float MaxDownAngle = -90f;

	private Rigidbody2D rb2d;
	private float currentVelocity;
	private float currentAngle;

	// Use this for initialization
	private void Awake () {
		rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (rb2d) {
			currentVelocity = Mathf.Clamp(rb2d.velocity.y, MaxDownVelocity, 0);
			currentAngle = (currentVelocity / MaxDownVelocity) * MaxDownAngle;
			Quaternion rotation = Quaternion.Euler(0, 0, currentAngle);
			transform.rotation = rotation;
		}
	}
}
