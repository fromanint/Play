using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(LevelInfo))]
public class LevelButton : MonoBehaviour {

	[HideInInspector]public LevelInfo level;
	[HideInInspector]public ConfirmPanel confirmPanel;
   

    [SerializeField] Text levelName;
	[SerializeField] Text levelPrice;
    [SerializeField] GameObject Stars;
    [SerializeField] GameObject Price;
	[SerializeField] Color haveStar;




	public void CopyLevelInfo(LevelInfo levelInfo)
	{
		
		level.CopyInfo (levelInfo);
	}
    
	public void ChooseLevel()
	{
		if (level.unlock) {
			SpawnLevel sl = FindObjectOfType<SpawnLevel> ();
			sl.index = level.levelName-1;
			//Var_Globales.levelSelected = level.levelName;
			SceneManager.LoadScene ("GuessLevel");
		} else {

			confirmPanel.objectName = "Level " + level.levelName.ToString();
			confirmPanel.objectPrice = level.price;
			confirmPanel.gameObject.SetActive (true);
		}

	}

	public void DisplayInfo(){
		ChangeState ();
		SetName ();
		SetStars ();
	}


	void Awake()
	{
		level = GetComponent<LevelInfo> ();

	}
     void SetStars()
    {
		
       
		Image[] stars = Stars.transform.GetComponentsInChildren<Image>();
        if (level.score >= level.maxScore * .6)
        {
			stars [1].color = haveStar;
        }
        if (level.score >= level.maxScore * .8)
        {
			stars[2].color = haveStar;
        }
        if (level.score >= level.maxScore * .95)
        {
			stars[3].color = haveStar;
        }

    }



     void ChangeState()
    {
		Stars.SetActive(level.unlock);
		Price.SetActive(!level.unlock);
    }

	 void SetName () {
		levelName.text = level.levelName.ToString();
		levelPrice.text = level.price.ToString ();
	}

    // Update is called once per frame

}
