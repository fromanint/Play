using UnityEngine;
using System.Collections;


[RequireComponent(typeof(SoundControl))]
public class InitGame : MonoBehaviour {

	GameControl GC;
    AudioSource AS;
	// Use this for initialization
	void Start () {
        
        GC = FindObjectOfType<GameControl> ();
		if (GC) {
			GC.score = 0;
		}
		ScoreUI score = FindObjectOfType<ScoreUI> ();
		if (score) {
			score.UpdateScore ();
		}
		Time.timeScale = 1;
	}

    public void setSound()
    {
        int sound = PlayerPrefs.GetInt("Sound", 1);
        if (sound == 1)
        {
         
            GetComponent<SoundControl>().PlayAudio();
        }
        else
        {
           
            GetComponent<SoundControl>().StopAudio();
        }
    }
}
