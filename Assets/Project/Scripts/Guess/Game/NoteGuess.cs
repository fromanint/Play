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
        if (other.gameObject.tag == "Player")
        {
            if (hitted)
            {
                GC.score++;
            }
            else {
                other.GetComponent<AudioSource>().clip = wrong;
                other.GetComponent<AudioSource>().Play();
            }
        }
        Destroy(gameObject);
    }

	void OnTriggerStay2D(Collider2D other)
	{
        if (other.gameObject.tag == "Player")
        {
            if (GC.actualNote == noteName)
            {
                Debug.Log(hitted);
                if (!hitted)
                { hitted = true; }
            }           
        }
    }
}
