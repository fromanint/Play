using UnityEngine;
using System.Collections;

public class AssignNote : MonoBehaviour {

    [SerializeField] string noteName;
	[SerializeField] string bassClefNote;
	[SerializeField] AudioClip Wrong;
	[SerializeField] AudioClip Correct;
    void Start() {

		GuessControl guessControl = FindObjectOfType<GuessControl> ();
       
		string giveNote = noteName;
		if (guessControl.bassClef) {
			giveNote = bassClefNote;
		} 

        FirstNote[] FN = GetComponentsInChildren<FirstNote>();
        foreach (FirstNote fn in FN)
        {
			fn.noteName = giveNote;
			fn.wrong = Wrong;
			fn.correct = Correct;
        }
        NoteGuess[] NG = GetComponentsInChildren<NoteGuess>();
        foreach (NoteGuess ng in NG)
        {
			ng.noteName = giveNote;
			ng.wrong = Wrong;
        }
    }
}
