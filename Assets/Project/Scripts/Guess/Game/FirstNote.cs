using UnityEngine;
using System.Collections;

public class FirstNote : MonoBehaviour {


 
public string noteName;

    GuessControl GC;
    void Start()
    {
		GC=GetComponentInParent<GuessControl>();
        if (!GC)
        {
            Debug.Log("No guess control script");
        }
       
    }



    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
		{
            if (GC.actualNote == noteName)
            { 
				GC.score++;
				GetComponent<Collider2D> ().enabled = false;
                Destroy(gameObject);
				Debug.Log (GC.score);
            }      
        }
    }
}
