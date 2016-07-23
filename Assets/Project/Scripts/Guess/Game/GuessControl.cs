using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(LevelInfo))]
public class GuessControl : MonoBehaviour {

	public int levelName;
	public int levelPrice;

    public int score = 0;
    public int maxNotes;
    public string actualNote;  




    public void Awake()
    {
		FirstNote[] fn = transform.GetComponentsInChildren<FirstNote>();
		NoteGuess[] ng = transform.GetComponentsInChildren<NoteGuess>();
		maxNotes = fn.Length + ng.Length;
		LevelInfo li = GetComponent<LevelInfo> ();
		li.SetInfo(levelName, levelPrice, maxNotes);

		score = 0;
		maxNotes = 0;
		actualNote = "";

        
    }

    public void SaveScore()
    {
		PlayerPrefs.SetInt("Level" + levelName.ToString() + "Score", score);
		SceneManager.LoadScene ("Guess");
    }

}
