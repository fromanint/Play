using UnityEngine;
using System.Collections;

public class AssignNote : MonoBehaviour {

    [SerializeField] string noteName;

    void Start() {
        FirstNote[] FN = GetComponentsInChildren<FirstNote>();
        foreach (FirstNote fn in FN)
        {
            fn.noteName = noteName;
        }
        NoteGuess[] NG = GetComponentsInChildren<NoteGuess>();
        foreach (NoteGuess ng in NG)
        {
            ng.noteName = noteName;
        }
    }
}
