using UnityEngine;
using System.Collections;


public class SpawnLevel : MonoBehaviour {
	[SerializeField] LevelInfo[] levels;
	[HideInInspector] public int index;

	void Awake() {
		index = 0;
		DontDestroyOnLoad(transform.gameObject);
	
	}


	public LevelInfo[] GetLevels(){
		return levels;
	}

	public LevelInfo Spawn(int i ){
		return Instantiate (levels [i]) as LevelInfo;
	}
	public LevelInfo Spawn(){
		return Instantiate (levels [index]) as LevelInfo;
	}
}
