using UnityEngine;
using System.Collections;

public class GuessControlTest : MonoBehaviour {

    [SerializeField]
    GuessControl GC;

    
    // Use this for initialization
    void Start()
    {

        GC = FindObjectOfType<GuessControl>();
        NoteButton[] buttons = GetComponentsInChildren<NoteButton>();
        foreach (NoteButton nb in buttons)
        {
            nb.AsignGuessControl(GC);
        }
    }

    void Update (){
        GC.UpdateScore();
    }
}
