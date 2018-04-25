using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

	public GameObject PowerUpPrefab;
	public int PowerUpPoolSize = 5;
	public float spawnRate = 3f;
	public float PowerUpMax = 3f;
	public float PowerUpMin = 0f;

	private GameObject[] PowerUps;
	private int currentPowerUp = 0;
	private Vector2 objectPoolPosition = new Vector2 (-30, -25);
	private float spawnXPosition = 10f;

	private float timeSinceLastSpawned;

	// Use this for initialization
	void Start () {

		timeSinceLastSpawned = 0f;

		PowerUps = new GameObject[PowerUpPoolSize];

		for (int i = 0; i < PowerUpPoolSize; i++) {
			PowerUps [i] = (GameObject)Instantiate (PowerUpPrefab, objectPoolPosition, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {

		timeSinceLastSpawned += Time.deltaTime;
		print (timeSinceLastSpawned);

		if (timeSinceLastSpawned >= spawnRate){
			
		timeSinceLastSpawned = 0f;

		float spawnYPosition = Random.Range (PowerUpMin, PowerUpMax);

		PowerUps[currentPowerUp].transform.position = new Vector3 (spawnXPosition, spawnYPosition, -1f);

		currentPowerUp++;

			if((currentPowerUp >= PowerUpPoolSize)){
				currentPowerUp = 0;
			}
				
		}
	}
}
 