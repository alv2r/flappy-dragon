using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingController : MonoBehaviour {

	public GameObject background;
	public GameObject platform;
	public GameObject cloud; 
	public GameObject mountains1; 
	public GameObject mountains2; 
	public GameObject mountains3; 

	private Renderer backgroundRenderer;
	private Renderer platformRenderer;
	private Renderer cloudRenderer;
	private Renderer mountains1Renderer;
	private Renderer mountains2Renderer;
	private Renderer mountains3Renderer;

	private float backgroundHorizontalLength;
	private float platformHorizontalLength;
	private float cloudHorizontalLength;
	private float mountains1HorizontalLength;
	private float mountains2HorizontalLength;
	private float mountains3HorizontalLength;

	private void Awake () {
		backgroundRenderer = background.GetComponent<Renderer>();
		platformRenderer = platform.GetComponent<Renderer>();
		cloudRenderer = cloud.GetComponent<Renderer>();
		mountains1Renderer = mountains1.GetComponent<Renderer>();
		mountains2Renderer = mountains1.GetComponent<Renderer>();
		mountains3Renderer = mountains3.GetComponent<Renderer>();
	}

	// Use this for initialization
	void Start () {
		backgroundHorizontalLength = backgroundRenderer.bounds.size.x;
		platformHorizontalLength = platformRenderer.bounds.size.x;
		cloudHorizontalLength = cloudRenderer.bounds.size.x;
		mountains1HorizontalLength = mountains1Renderer.bounds.size.x;
		mountains2HorizontalLength = mountains2Renderer.bounds.size.x;
		mountains3HorizontalLength = mountains3Renderer.bounds.size.x;

		Debug.Log(backgroundHorizontalLength);
		Debug.Log(platformHorizontalLength);
	}
	
	// Update is called once per frame
	void Update () {
		if (background.transform.position.x < -backgroundHorizontalLength) {
			RepositionParallax(background, backgroundHorizontalLength);
		}

		if (platform.transform.position.x < -platformHorizontalLength) {
			RepositionParallax(platform, platformHorizontalLength);
		}

		if (cloud.transform.position.x < -cloudHorizontalLength) {
			RepositionParallax(cloud, cloudHorizontalLength);
		}

		if (mountains1.transform.position.x < -mountains1HorizontalLength) {
			RepositionParallax(mountains1, mountains1HorizontalLength);
		}

		if (mountains2.transform.position.x < -mountains2HorizontalLength) {
			RepositionParallax(mountains2, mountains2HorizontalLength);
		}

		if (mountains3.transform.position.x < -mountains3HorizontalLength) {
			RepositionParallax(mountains3, mountains3HorizontalLength);
		}
	}

	void RepositionParallax (GameObject gameObject, float horizontalLength) {
		gameObject.transform.Translate(Vector2.right * horizontalLength * 2);
	}
}
