using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class ScoreUI : MonoBehaviour {

	public void UpdateScore(){
		GetComponent<Text>().text =  "X" + FindObjectOfType<GameControl> ().score.ToString();
	}

}
