using UnityEngine;
using System.Collections;

public class FirstNote : MonoBehaviour {


 
public string noteName;
	[HideInInspector]
    public AudioClip wrong;
	[HideInInspector]
    public AudioClip correct;
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
                GC.UpdateScore();
                other.gameObject.GetComponent<AudioSource>().clip = correct;
                other.gameObject.GetComponent<AudioSource>().Play();             
                GetComponent<Collider2D>().enabled = false;
                Destroy(gameObject);
                Debug.Log(GC.score);
            }
            else {
                other.gameObject.GetComponent<AudioSource>().clip = wrong;
                other.gameObject.GetComponent<AudioSource>().Play();
            }   
        }
    }
}
