using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuDragonController : MonoBehaviour {

	private Rigidbody2D rb2d;

	private void Awake() {
		rb2d = GetComponent<Rigidbody2D>();
	}

	// Use this for initialization
	void Start () {
		rb2d.velocity = Vector2.right * 1.2f;
	}
	
	void OnBecameInvisible() {
		transform.position = new Vector2(-10f, 1.5f);
	}
}
