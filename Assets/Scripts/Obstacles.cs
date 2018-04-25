using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {

		if (other.GetComponent<Jet> () != null) {

			GameControl.instance.BirdScored ();
		}

	}
}
