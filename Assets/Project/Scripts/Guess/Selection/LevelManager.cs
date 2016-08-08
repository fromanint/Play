using UnityEngine;
using System.Collections;



public class LevelManager : MonoBehaviour {
   
    [SerializeField]
    LevelButton levelsButton;
	[SerializeField] int maxLevels;
    [SerializeField] ConfirmPanel confirmPanel;

    SpawnLevel sl;
   
    int levels;
	// Use this for initialization
	void Awake () {
	   // CP= FindObjectOfType<ConfirmPanel> ();
		sl = FindObjectOfType<SpawnLevel> ();
        levels = 0;
        GenerateLevels(maxLevels);
	}

    public void Next()
    {
        if (levels < sl.GetLevels().Length)
        {
            ClearLevels();
            GenerateLevels(levels + maxLevels);
        }
        else
        {
            Debug.Log("no more levels");
        }
    }

    public void Previous()
    {

        Debug.Log(levels);
        if (levels - maxLevels >= 0)
        {
            ClearLevels();
            levels -= maxLevels;
            GenerateLevels( maxLevels);
        }
        else {
            Debug.Log("no more levels");
        }
    }

    void ClearLevels()
    {
        foreach (Transform t in transform)
        {
            Destroy(t.gameObject);
        }
    }

    void GenerateLevels(int maxlevel)
    {
        //CP = FindObjectOfType<ConfirmPanel>();
        int lastlLevel = levels;
        for (levels = lastlLevel; levels < sl.GetLevels().Length; levels++)
        {
            if (levels >= maxlevel)
            { break; }
            LevelButton newButton = Instantiate(levelsButton) as LevelButton;
            newButton.transform.SetParent(transform, false);

            LevelInfo li = sl.GetLevelInfo(levels);


            newButton.CopyLevelInfo(li);
            newButton.DisplayInfo();
          //  Destroy(li.gameObject);

            if (!confirmPanel)
            {
                Debug.Log("confirm panel not found");
            }
            else {
                newButton.confirmPanel = confirmPanel;
            }
        }
    }


}
