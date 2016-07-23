
using UnityEngine;
using System.Collections;

public class NoteButton : MonoBehaviour {

    [SerializeField] string buttonNote;
    [SerializeField] float delay;

    GuessControl GC;

	public void AsignGuessControl(GuessControl gc)
    {
		

		GC = gc;
       
    }

    public void Pushed(){
		if (!GC) {
			Debug.Log("No guesscontrol object");
		}

        StartCoroutine("Change");
    }

    IEnumerator Change(){
        GC.actualNote = buttonNote;
		Debug.Log ("pushed" + GC.actualNote);
        yield return new WaitForSeconds(delay);
        GC.actualNote = "";
        }

}
