using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonController : MonoBehaviour {

	private bool isAlive;
	private Rigidbody2D rb2d;

	public float upForce;

	// Is called when the script instance is being loaded. Used to initialize any 
	// variables or game state before the game starts
	private void Awake() {
		rb2d = GetComponent<Rigidbody2D>();
		isAlive = true;
		upForce = 200f;
	}

	// Use this for initialization
	private void Start () {
		
	}
	
	// Update is called once per frame
	private void Update () {
		if (!isAlive) return; 

		if (Input.GetMouseButtonDown(0)) {
			// When the dragon is falling is necessary to reset its velocity
			// to give the proper impulse
			rb2d.velocity = Vector2.zero;
			rb2d.AddForce(Vector2.up * upForce);
		}
	}

	private void OnCollisionEnter2D(Collision2D collision) {
		isAlive = false;
	}
}
