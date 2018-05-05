using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnsPool : MonoBehaviour {

	public int numberOfColumns = 5;
	public float columnMinY = -2f;
	public float columMaxY = 1.5f;
	private float spawnXposition = 10f;

	public GameObject columnPrefab;

	private GameObject[] columns;
	private Vector2 objectPoolPosition = new Vector2(-14, 0);

	private float timeSinceLastSpawn;
	public float spawnRate;

	private int currentColumn = 0;

	// Use this for initialization
	void Start () {
		columns = new GameObject[numberOfColumns];
		for (int i = 0; i < numberOfColumns; i++) {
			columns[i] = Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		timeSinceLastSpawn += Time.deltaTime;
		if (!GameController.instance.gameOverState && timeSinceLastSpawn >= spawnRate) {
			timeSinceLastSpawn = 0;
			float spawnYPosition = Random.Range(columnMinY, columMaxY);
			columns[currentColumn].transform.position = new Vector2(spawnXposition, spawnYPosition);
			currentColumn++; 

			if (currentColumn >= numberOfColumns) {
				currentColumn = 0;
			}
		}
	}
}
