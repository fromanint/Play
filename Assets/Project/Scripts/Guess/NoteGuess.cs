using UnityEngine;
using System.Collections;

public class NoteGuess : MonoBehaviour {


    [HideInInspector]
    public string noteName;

    GuessControl GC;
    void Start()
    {
        GC = FindObjectOfType<GuessControl>();
        if (!GC)
        {
            Debug.Log("No guess control script");
        }
        GC.maxNotes++;
    }


    void OnTriggerExit2D(Collider2D other){
        Destroy(gameObject);
    }

	void OnTriggerStay2D(Collider2D other)
	{
        if (other.gameObject.tag == "Player")
        {
            if (GC.actualNote == noteName)
            {
                GC.score++;
             
            }
        }
    }
}
