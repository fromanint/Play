using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {

	void Start()
	{
		Time.timeScale = 1;
	}

	void Update () {
		//Quit Game whe press back
		if (Input.GetKeyDown(KeyCode.Escape))
		{ Application.Quit(); }
	}
}
