using UnityEngine;
using System.Collections;

public class AssignGuessControl : MonoBehaviour {



	// Use this for initialization
	void Start () {
		SpawnLevel sp = FindObjectOfType<SpawnLevel> ();
		sp.Spawn ();
		GuessControl gc = FindObjectOfType<GuessControl> ();
		NoteButton[] buttons = GetComponentsInChildren<NoteButton> ();
		foreach (NoteButton nb in buttons) {
			nb.AsignGuessControl (gc);
		}
	}

}
