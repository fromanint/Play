using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {


	GameObject Player;

	Vector3 targetPos;
	bool Follow = true;
	// Use this for initialization
	void Start () {
		targetPos = transform.position;
		Player = GameObject.FindGameObjectWithTag("Player"); 
	}


	// Update is called once per frame
	void FixedUpdate () {
		if (Player)
		{
			targetPos.x = Player.transform.position.x;

			transform.position = targetPos;
		}
	}
}
