using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour {

	public float objectSpeed;

	private Rigidbody2D rb2dObject;

	private void Awake() {
		rb2dObject = GetComponent<Rigidbody2D>();
	}

	// Use this for initialization
	private void Start () {
		rb2dObject.velocity = Vector2.left * GameController.instance.parallaxSpeed * objectSpeed;
	}

	// Update is called once per frame
	private void Update () {
		if(GameController.instance.gameOverState) {
			rb2dObject.velocity = Vector2.zero;
		}
	}
}
