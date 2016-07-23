using UnityEngine;
using System.Collections;

public class FinishNote : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Player") {
		//	FindObjectOfType<GuessControl> ().SaveScore;

		}
	}
}
