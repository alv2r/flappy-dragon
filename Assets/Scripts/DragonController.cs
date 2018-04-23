using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonController : MonoBehaviour {

	// Primitive variables
	public float upForce;
	private bool isAlive;

	// Unity variables
	private Rigidbody2D rb2d;
	private Animator anim;


	// Is called when the script instance is being loaded. Used to initialize any 
	// variables or game state before the game starts
	private void Awake() {
		rb2d = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
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
			anim.SetTrigger("Flap");
		}
	}

	private void OnCollisionEnter2D(Collision2D collision) {
		isAlive = false;
		anim.SetTrigger("Die");
		GameController.instance.activateGameOverText();
	}
}
