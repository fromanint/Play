
using UnityEngine;
using System.Collections;

public class NoteButton : MonoBehaviour {

    [SerializeField] string buttonNote;
    [SerializeField] float delay;

    GuessControl GC;

    void Start()
    {
        GC = FindObjectOfType<GuessControl>();
        if (!GC) {
            Debug.Log("No guesscontrol object");
        }
    }

    public void Pushed(){
        StartCoroutine("Change");
    }

    IEnumerator Change(){
        GC.actualNote = buttonNote;
        yield return new WaitForSeconds(delay);
        GC.actualNote = "";
        }

}
