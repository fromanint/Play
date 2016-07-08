using UnityEngine;
using System.Collections;

public class SpawnObjects : MonoBehaviour
{
	
	[SerializeField] GameObject[] Obstacles;        // Array of Obstacles prefabs.
    [SerializeField] GameObject parent;
    [SerializeField] float spawnTime = 10f;        // The amount of time between each spawn.
    [SerializeField] public float spawnDelay = 20f;       // The amount of time before spawning starts.

    [SerializeField] float minTime;
    [SerializeField] float maxTime;

    float delay;
    PlayerControl player;

    void Start ()
	{
        // Start calling the Spawn function repeatedly after a delay .
        StartCoroutine("SpawnObject");
        player = FindObjectOfType<PlayerControl>();
    }

    IEnumerator SpawnObject()
    {
        delay = Random.Range(minTime, maxTime);
        yield return new WaitForSeconds(delay);
        if(player.speed != 0)
        { 
            Spawn();
        }
        StartCoroutine("SpawnObject");
    }

	void Spawn ()
	{

		    int enemyIndex = Random.Range(0, Obstacles.Length);
		    GameObject GO = Instantiate(Obstacles[enemyIndex], transform.position, transform.rotation) as GameObject;
		    GO.transform.parent = parent.transform;
     
       


    }
}
