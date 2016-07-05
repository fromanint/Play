using UnityEngine;
using System.Collections;

public class Notes : MonoBehaviour {

	// Use this for initialization
	void Start () {
        FindObjectOfType<GameControl>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {

        }
    }
}
