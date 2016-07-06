using UnityEngine;
using System.Collections;

public class Notes : MonoBehaviour {

	[SerializeField] int points;

	GameControl GC;

	// Use this for initialization
	void Start () {
		GC = FindObjectOfType<GameControl>();

	}
	


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
			GC.score += points;
			FindObjectOfType<ScoreUI> ().UpdateScore ();
			Destroy (gameObject);
        }
    }
}
