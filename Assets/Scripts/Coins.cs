using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour {

	//public static Coins coins;

	//void Awake(){
		
	//	if (coins == null)
	//		coins = this;

	//	print ("check");
	//	Renderer rend = this.GetComponent<Renderer>();
	//	rend.enabled = true;
	//}

	void OnTriggerEnter2D(Collider2D other) {

		if (other.GetComponent<Jet> () != null) {
			AudioSource audio = this.gameObject.GetComponent<AudioSource> ();
			audio.Play ();
			GameControl.instance.BirdScored ();
			//this.gameObject.SetActive (false);
			Renderer rend = this.GetComponent<Renderer>();
			rend.enabled = false;
		}

	}
}
