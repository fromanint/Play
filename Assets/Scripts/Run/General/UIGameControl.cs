using UnityEngine;
using System.Collections;

public class UIGameControl : MonoBehaviour {

	[SerializeField] GameObject gameOver;
	[SerializeField] GameObject pause;
	[SerializeField] GameObject inGame;

	float actualTime;

	void Start(){
		actualTime = 1f;
		if (gameOver && pause && inGame) {
			InGame ();
		} else {Debug.Log ("Missing panel gameOver, pause or in game"); 
			enabled = false;
		}
	
	}

	public void GameOver()
	{
		gameOver.SetActive (true);
		inGame.SetActive (false);
		pause.SetActive (false);
		Stop ();
	}

	public void InGame(){
		inGame.SetActive (true);
		pause.SetActive (false);
		gameOver.SetActive (false);
		Continue ();
	}

	public void Pause(){
		actualTime = Time.timeScale;
		inGame.SetActive (false);
		pause.SetActive (true);
		gameOver.SetActive (false);
		Stop ();
	}



	void Stop(){
		Time.timeScale = 0;
	}

	void Continue(){
		
		Time.timeScale = actualTime;
		Debug.Log (Time.timeScale);
	}

}
