using UnityEngine;
using System.Collections;


public class SpawnLevel : MonoBehaviour {
	[SerializeField] GuessControl[] levels;
	[HideInInspector] public int index;

	void Awake() {
		index = 0;
		DontDestroyOnLoad(transform.gameObject);
	
	}

    public LevelInfo GetLevelInfo(int i) {
        return levels[i].GuessControlToLevelInfo();
    }

	public GuessControl[] GetLevels(){
		return levels;
	}

	public GuessControl Spawn(int i ){
		return Instantiate (levels [i]) as GuessControl;
	}
	public GuessControl Spawn(){
		return Instantiate (levels [index]) as GuessControl;
	}
}
