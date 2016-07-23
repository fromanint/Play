using UnityEngine;
using System.Collections;

public class LevelInfo : MonoBehaviour {


	public int levelName;
	public int price;
	public int maxScore;
	[HideInInspector] public bool unlock;
	[HideInInspector] public int score;

	public void SetInfo(int l, int p, int max){
		levelName = l;
		price = p;
		maxScore = max;
		unlock = false;
		score = PlayerPrefs.GetInt("Level" + levelName.ToString() + "Score", 0);

		int getUnlock = PlayerPrefs.GetInt("Level" + levelName.ToString() , 0 );


		if (getUnlock == 0)
		{
			unlock = false;
		}
		else
		{
			unlock = true;
		}
	}

	public void CopyInfo (LevelInfo newInfo)
	{
		levelName = newInfo.levelName;
		price = newInfo.price;
		maxScore = newInfo.maxScore;
		unlock = newInfo.unlock;
		score = newInfo.score;
	}









}
