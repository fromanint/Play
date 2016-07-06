using UnityEngine;
using System.Collections;

public class SpawnObjects : MonoBehaviour
{
	
	[SerializeField] GameObject[] Obstacles;        // Array of Obstacles prefabs.
    [SerializeField] GameObject parent;
    [SerializeField] float spawnTime = 10f;        // The amount of time between each spawn.
    [SerializeField] public float spawnDelay = 20f;       // The amount of time before spawning starts.


    void Start ()
	{
        // Start calling the Spawn function repeatedly after a delay .
        //InvokeRepeating("Spawn", spawnDelay, spawnTime);
        
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
  
	}


	void Spawn ()
	{
		// Instantiate a random enemy.
        if(Time.timeScale>1)
        { 
            
		    int enemyIndex = Random.Range(0, Obstacles.Length);
		    GameObject GO = Instantiate(Obstacles[enemyIndex], transform.position, transform.rotation) as GameObject;
		    GO.transform.parent = parent.transform;
         //   Debug.Log(GO.name);
        }


    }
}
