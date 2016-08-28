using UnityEngine;
using System.Collections;


public class SpawnLevel : MonoBehaviour {
	[SerializeField] GuessControl[] levels;
	[HideInInspector] public int index;
	[HideInInspector] public bool bassClef;


	private static SpawnLevel _instance ;
	void Awake() {
		index = 0;

		//if we don't have an [_instance] set yet
		if(!_instance)
			_instance = this ;
		//otherwise, if we do, kill this thing
		else
			Destroy(this.gameObject);
		
		DontDestroyOnLoad(transform.gameObject);

	
	}

    public LevelInfo GetLevelInfo(int i) {
        return levels[i].GuessControlToLevelInfo();
    }

	public GuessControl[] GetLevels(){
		return levels;
	}
		
	public void ChangeClef()
	{
		bassClef = !bassClef;
		Debug.Log(bassClef + "bass Clef");
	}
	public GuessControl Spawn(int i ){
		GuessControl newLevel = Instantiate (levels [i]) as GuessControl;
		newLevel.bassClef = bassClef;
		return newLevel;
	}
	public GuessControl Spawn(){
		GuessControl newLevel = Instantiate (levels [index]) as GuessControl;
		newLevel.bassClef = bassClef;
		return newLevel;
	}
}
