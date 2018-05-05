using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	// This is a singleton, allows to call the class from any script
	public static GameController instance;

	public float parallaxSpeed = 1;
	public bool gameOverState;
	public GameObject gameOverText;
	public Text scoreText;

	private int score;

	private void Awake() {
		// Manages multiples instance of the GameController when there are
		// multiple scenes with this class, only instantiate one 
		if (GameController.instance == null){
			GameController.instance = this;
		} else if (GameController.instance != this) {
			Destroy(gameObject);
			Debug.LogWarning("GameController instantiated a second time");
		}
	}

	// Use this for initialization
	private void Start () {
		
	}
	
	// Update is called once per frame
	private void Update () {
//		if (gameOverState && Input.GetMouseButtonDown(0)) {
//			//SceneManager.LoadScene("Main");
//			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
//		}
	}

	private void OnDestroy() {
		if (GameController.instance == this) {
			GameController.instance = null;
		}
	}

	public void activateGameOverText () {
		gameOverState = true;
		gameOverText.SetActive(true);
	}

	public void incrementScore () {
		if (gameOverState) return;
		score++; 
		scoreText.text = score.ToString();
	}

	public void restartGame () {
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
