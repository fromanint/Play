using UnityEngine;
using System.Collections;

public class FirstNote : MonoBehaviour {


[HideInInspector]    
public string noteName;

    GuessControl GC;
    void Start()
    {
        GC=FindObjectOfType<GuessControl>();
        if (!GC)
        {
            Debug.Log("No guess control script");
        }
        GC.maxNotes++;
    }



    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (GC.actualNote == noteName)
            { GC.score++;
                Destroy(gameObject);
            }      
        }
    }
}
