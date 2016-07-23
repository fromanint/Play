using UnityEngine;
using System.Collections;



public class LevelManager : MonoBehaviour {
    [SerializeField]
	LevelInfo[] levels;
    [SerializeField]
    LevelButton levelsButton;
	[SerializeField] int maxLevels;


	// Use this for initialization
	void Awake () {
		ConfirmPanel CP= FindObjectOfType<ConfirmPanel> ();
		SpawnLevel sl = FindObjectOfType<SpawnLevel> ();

		for (int i = 0; i < sl.GetLevels().Length; i++)
        {
            LevelButton newButton = Instantiate(levelsButton) as LevelButton;
            newButton.transform.SetParent(transform, false);

			LevelInfo li = sl.Spawn (i);


			newButton.CopyLevelInfo (li);
			newButton.DisplayInfo ();
			Destroy (li.gameObject);

			if (!CP) {
				Debug.Log ("confirm panel not found");
			}
			else {
				newButton.confirmPanel = CP;
			}
        
        }
	}
	

}
