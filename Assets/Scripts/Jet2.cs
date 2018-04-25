using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jet2 : MonoBehaviour {

	public LevelManager levelmanager;
	public ScrollingObject scrollingobject;
	public float upForce;

	private bool isDead = false;
	private Rigidbody2D rb2d;


	// Use this for initialization
	void Start () {


		rb2d = GetComponent<Rigidbody2D> ();

	}

	// Update is called once per frame
	void Update () {

		if (isDead == false) {
			if (Input.GetKeyDown(KeyCode.Space) == true) {
				AudioSource audio = this.gameObject.GetComponent<AudioSource> ();
				audio.Play ();
			}

			if (Input.GetKey(KeyCode.Space)) {
				rb2d.velocity = Vector2.zero;
				rb2d.AddForce (new Vector2 (0, upForce));
				//AudioSource audio = this.gameObject.GetComponent<AudioSource> ();
				//audio.Play ();
				//this.GetComponent.<AudioSource>()

			}
			if (Input.GetKey(KeyCode.Space) ==false) {
				//rb2d.velocity = Vector2.zero;
				//rb2d.AddForce (new Vector2 (0, upForce));
				AudioSource audio = this.gameObject.GetComponent<AudioSource> ();
				audio.Stop ();
				//this.GetComponent.<AudioSource>()

			}
		}
	}

	void OnCollisionEnter2D(Collision2D other) {


			rb2d.velocity = Vector2.zero;
			isDead = true;
		
			GameControl.instance.BirdDied ();

	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "speedup") {
			rb2d.velocity = new Vector2 (3.5f, 0);
		}
	}

}
