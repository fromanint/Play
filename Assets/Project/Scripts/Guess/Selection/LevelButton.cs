using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour {

    [HideInInspector] public int level;
    [HideInInspector] public int price;
    [HideInInspector] public int maxScore;

    [SerializeField] Text levelName;
    [SerializeField] GameObject Stars;
    [SerializeField] GameObject Price;

    

    int unlock;
    int score;
    // Use this for initialization
    void Start() {
        PlayerPrefs.SetInt("Level" + level.ToString(), 1);
        unlock = PlayerPrefs.GetInt("Level" + level.ToString() , 0 );
        

        if (unlock == 0)
        {
            ChangeState(false);
        }
        else
        {
            ChangeState(true);
            SetStars();
        }


    }


    public void SetStars()
    {
        score = PlayerPrefs.GetInt("Level" + level.ToString() + "Score", 0);
        Image[] stars = transform.GetComponentsInChildren<Image>();
        if (score >= maxScore * .6)
        {
            stars[0].color = new Color(234, 324, 112);
        }
        if (score >= maxScore * .8)
        {
            stars[1].color = new Color(234, 324, 112);
        }
        if (score >= maxScore * .95)
        {
            stars[2].color = new Color(234, 324, 112);
        }

    }

    public void ChangeState(bool state)
    {
        GetComponent<Button>().interactable = state;
        Stars.SetActive(state);
        Price.SetActive(!state);
    }

	public void SetName () {
        levelName.text = level.ToString();
       
	}

    // Update is called once per frame
    public void ChooseLevel()
    {
        Debug.Log(level-1);
    }
}
