using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		//Quit Game whe press back
		if (Input.GetKeyDown(KeyCode.Escape)) 
			Application.Quit(); 
	}
}
