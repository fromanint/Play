using UnityEngine;
using System.Collections;

public class NoteGuess : MonoBehaviour {
    [SerializeField]
    AudioClip wrong;

    [HideInInspector]
    public string noteName;
	bool hitted;

    GuessControl GC;
    void Start()
    {
        GC = FindObjectOfType<GuessControl>();
        if (!GC)
        {
            Debug.Log("No guess control script");
        }
		hitted = false;
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
				hitted = true;
            }
            else {
				if (hitted) {
					other.GetComponent<AudioSource> ().clip = wrong;
					other.GetComponent<AudioSource> ().Play ();
				}
            }
        }
    }
}
