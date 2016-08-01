using UnityEngine;
using System.Collections;

[RequireComponent(typeof(FXSound))]
[RequireComponent(typeof(SpriteRenderer))]
public class Obstacle : MonoBehaviour {

	[SerializeField] float damage;
	[SerializeField] float destroyDelay;
	[SerializeField] float blinkDelay;

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Player") {
            GetComponent<Collider2D>().enabled = false;
            other.gameObject.GetComponent<PlayerControl> ().ManageLifes (destroyDelay);
			other.gameObject.GetComponent<Rigidbody2D> ().velocity = Vector3.zero;
            GetComponent<FXSound>().PlaySoundFX(other);
            StartCoroutine ("DesetroyObstacle",other.gameObject);


		}
	}

	IEnumerator DesetroyObstacle(GameObject other){

        yield return new WaitForSeconds (destroyDelay);
		other.GetComponent<PlayerControl> ().StartCoroutine ("StartRun");
		Destroy (gameObject);
	}
}
