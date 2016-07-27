using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {


	[SerializeField]GameObject Player;

	Vector3 targetPos;

    [SerializeField] float maxOffset;
    [SerializeField] float offsetStart;
	bool Follow = true;

    float offset;
	// Use this for initialization
	void Start () {
		targetPos = transform.position;
		//Player = GameObject.FindGameObjectWithTag("Player");
       
        offset = 0;
	}


	// Update is called once per frame
	void FixedUpdate () {
		if (Player)
		{
			targetPos.x = Player.transform.position.x+offset;

            transform.position = targetPos;
            if (offset <= maxOffset)
            {
                offset += offsetStart;
            } 
		}
	}
}
