using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	void Update(){
		
	}

	public void LoadLevel(string name) {
		SceneManager.LoadScene (name);
	}

}
