using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyController : MonoBehaviour {

	// Velocity
	public float MinXVelocity = -1f;
	public float MaxXVelocity = -5f;
	public float MinYVelocity = 1f;
	public float MaxYVelocity = 5f;

	private Rigidbody2D flyRb2d;

	private void Awake() {
		flyRb2d = GetComponent<Rigidbody2D>();
	}

	// Use this for initialization
	void Start () {
		float spwanXVelocity = Random.Range(MinXVelocity, MaxXVelocity);
		float spwanYVelocity = Random.Range(MinYVelocity, MaxYVelocity);
		flyRb2d.velocity = new Vector2(spwanXVelocity, spwanYVelocity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Whenever and object collides with this object
	void OnTriggerEnter2D(Collider2D other){
		// Tags are used to identify which object 
		if (other.gameObject.tag == "Destroyer") {
			Destroy(gameObject);
		}
	}
}
