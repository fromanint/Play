using UnityEngine;
using System.Collections;



public class LevelManager : MonoBehaviour {
    [SerializeField]
    GameObject[] levels;
    [SerializeField]
    LevelButton levelsButton;
	// Use this for initialization
	void Start () {
        for (int i = 0; i < levels.Length; i++)
        {
            LevelButton newButton = Instantiate(levelsButton) as LevelButton;
            newButton.transform.SetParent(transform, false);
            newButton.level = i + 1;
            newButton.SetName();
            newButton.maxScore = 0;
        }
	}
	

}
