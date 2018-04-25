using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

	public static GameControl instance;
	public Text scoreText;
	public GameObject gameOvertext;

	public LevelManager levelmanager;
	private int score = 0;
	public bool gameOver = false;


	void Awake()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
		}

	void Update() {
	}

	public void BirdScored() {
		if (gameOver) {
			return;
		}
		score++;
		scoreText.text = "Score: " + score.ToString ();
	}

	public void BirdDied(){


		levelmanager.LoadLevel ("Lose Screen");
		gameOver = true;
	}

}