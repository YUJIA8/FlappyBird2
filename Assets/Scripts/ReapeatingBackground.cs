using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReapeatingBackground : MonoBehaviour {

	public BoxCollider2D ground;
	private float groundHorizontalLengh;



	// Use this for initialization
	void Awake () {

		ground = GetComponent<BoxCollider2D> ();
		groundHorizontalLengh = ground.size.x - 0.52f;

		//print (groundHorizontalLengh);
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.x <= -groundHorizontalLengh) {

			RepositionBackground ();
			//print (transform.position);
		}
	}

	void RepositionBackground () {

		Vector2 groundOffset = new Vector2 (groundHorizontalLengh * 2f, 0);
		transform.position = (Vector2)transform.position + groundOffset;
	}
}


	