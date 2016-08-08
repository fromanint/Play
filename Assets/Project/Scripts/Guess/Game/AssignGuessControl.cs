using UnityEngine;
using System.Collections;

public class AssignGuessControl : MonoBehaviour {

    [SerializeField]
    GuessScore GS;

	// Use this for initialization
	void Start () {
        
        Debug.Log(gameObject.name);
		SpawnLevel sp = FindObjectOfType<SpawnLevel> ();
		sp.Spawn ();
		GuessControl gc = FindObjectOfType<GuessControl> ();
		NoteButton[] buttons = GetComponentsInChildren<NoteButton> ();
		foreach (NoteButton nb in buttons) {
			nb.AsignGuessControl (gc);
		}
        GS.GC = gc;
	}

}
