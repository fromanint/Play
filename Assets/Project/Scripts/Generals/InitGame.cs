using UnityEngine;
using System.Collections;

public class InitGame : MonoBehaviour {

	GameControl GC;

	// Use this for initialization
	void Start () {
		GC = FindObjectOfType<GameControl> ();
		if (GC) {
			GC.score = 0;
		}
		ScoreUI score = FindObjectOfType<ScoreUI> ();
		if (score) {
			score.UpdateScore ();
		}
		Time.timeScale = 1;
	}
	

}
