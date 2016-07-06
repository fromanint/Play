using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

	[SerializeField] float damage;
	[SerializeField] float destroyDelay;
	[SerializeField] float blinkDelay;

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Player") {
			other.gameObject.GetComponent<PlayerControl> ().ManageLifes ();
			other.gameObject.GetComponent<Rigidbody2D> ().velocity = Vector3.zero;
			other.gameObject.GetComponent<Animator> ().SetTrigger ("Hit");
			StartCoroutine ("DesetroyObstacle",other.gameObject);


		}
	}

	IEnumerator DesetroyObstacle(GameObject other){


		yield return new WaitForSeconds (destroyDelay);

		other.GetComponent<PlayerControl> ().StartCoroutine ("StartRun");
		Destroy (gameObject);
	}
}
