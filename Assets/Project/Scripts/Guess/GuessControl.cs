using UnityEngine;
using System.Collections;

public class GuessControl : MonoBehaviour {

    public int score = 0;
    public float maxNotes;
    public string actualNote;  

    void Awake()
    {
        score = 0;
        maxNotes = 0;
        actualNote = "";
        
    }

    public void SaveScore()
    {
       /* int newScore = PlayerPrefs.GetInt("Score", 0);
        newScore += score;
        PlayerPrefs.SetInt("Score", newScore);

        float highRun = PlayerPrefs.GetFloat("Distance", 0);

        if (highRun <= run)
        {

            PlayerPrefs.SetFloat("Distance", run);
        }*/
    }

}
