using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(LevelInfo))]
public class GuessControl : MonoBehaviour {

	public int levelName;
	public int levelPrice;

    public int[] scoreStar;
 

    public int score = 0;
    public int maxNotes;
    public string actualNote;

    [HideInInspector] public GuessScore guessScore;
    [HideInInspector] public int stars; 
	[HideInInspector] public bool bassClef;

    void Start()
    {
        Debug.Log(SceneManager.GetActiveScene().ToString());
        FirstNote[] fn = transform.GetComponentsInChildren<FirstNote>();
		NoteGuess[] ng = transform.GetComponentsInChildren<NoteGuess>();
		maxNotes = fn.Length + ng.Length;
		LevelInfo li = GetComponent<LevelInfo> ();
		li.SetInfo(levelName, levelPrice, maxNotes);

		score = 0;
		maxNotes = li.maxScore;
		actualNote = "";
        guessScore = FindObjectOfType<GuessScore>();
        stars = -1;
        for (int i = 0; i < scoreStar.Length; i++)
        {
            guessScore.MoveStar(scoreStar[i], i);
        }
       
    }



    public void UpdateScore()
    {
        float x = (float)score / (float)maxNotes;
        if(stars+1 < scoreStar.Length)
        { 
            if (x*100 >= scoreStar[stars+1] )
            {
                stars++;
                Debug.Log(stars);
            }
        }


        guessScore.UpdateScore(x,stars);
    }

    public void SaveScore()
    {
        if (PlayerPrefs.GetInt("Level" + levelName.ToString() + "Score", 0) < stars+1)
            {		PlayerPrefs.SetInt("Level" + levelName.ToString() + "Score", stars+1); }

        FindObjectOfType<UIGameControl>().GameOver();
        Debug.Log("Finish");
        
    }

    public void LoadScore()
    {
        PlayerPrefs.GetInt("Level" + levelName.ToString() + "Score", 0);
    }

    public LevelInfo GuessControlToLevelInfo()
    {
        LevelInfo l = new LevelInfo();
        l.SetInfo(levelName, levelPrice, maxNotes);
        return l;
    }
}
