using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuFlyController : MonoBehaviour {
	// Position 
	public float flyMinY = -3f;
	public float flyMaxY = 4f;
	private float spawnXposition = 10f;
	private Vector2 flyPosition;

	public GameObject flyPrefab;
	private GameObject myFly; 

	// Spawn time 
	private float timeSinceLastSpawn;
	public float spawnRate;



	private void Awake() {
		//rb2dObject = GetComponent<Rigidbody2D>();
	}
		
	// Use this for initialization
	void Start () {
		//rb2dObject.velocity = new Vector2(-2f, 2f);
	}
	
	void Update () {
		timeSinceLastSpawn += Time.deltaTime;
		if (timeSinceLastSpawn >= spawnRate) {
			timeSinceLastSpawn = 0;
			float spawnYPosition = Random.Range(flyMinY, flyMaxY);

			flyPosition = new Vector2(spawnXposition, spawnYPosition);
			myFly = Instantiate(flyPrefab, flyPosition, Quaternion.identity);
		}
	}
}
