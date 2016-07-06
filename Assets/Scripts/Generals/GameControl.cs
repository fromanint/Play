using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {

	
	public int score;

	public void SaveScore(){
		int newScore = PlayerPrefs.GetInt ("Score", 0);
		newScore += score;
		PlayerPrefs.SetInt ("Score", newScore);
	}


}
