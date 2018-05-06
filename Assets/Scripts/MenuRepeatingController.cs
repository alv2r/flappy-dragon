using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuRepeatingController : MonoBehaviour {

	public GameObject cloud; 

	private Renderer cloudRenderer;

	private float cloudHorizontalLength;

	private void Awake () {
		cloudRenderer = cloud.GetComponent<Renderer>();
	}

	// Use this for initialization
	void Start () {
		cloudHorizontalLength = cloudRenderer.bounds.size.x;
	}

	// Update is called once per frame
	void Update () {
		if (cloud.transform.position.x < -cloudHorizontalLength) {
			RepositionParallax(cloud, cloudHorizontalLength);
		}
	}

	void RepositionParallax (GameObject gameObject, float horizontalLength) {
		gameObject.transform.Translate(Vector2.right * horizontalLength * 2);
	}
}
