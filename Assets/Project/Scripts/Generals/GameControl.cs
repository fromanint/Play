using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {

	
	public int score =0;
    public float run = 0;

    void Start()
    {
        score = 0;
        run = 0;
    }

	public void SaveScore(){
		int newScore = PlayerPrefs.GetInt ("Score", 0);
		newScore += score;
		PlayerPrefs.SetInt ("Score", newScore);

        float highRun = PlayerPrefs.GetFloat("Distance", 0);

        if (highRun <= run)
        {
         
            PlayerPrefs.SetFloat("Distance", run);
        }
	}


}
