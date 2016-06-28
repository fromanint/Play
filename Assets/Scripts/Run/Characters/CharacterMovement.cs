using UnityEngine;
using System.Collections;


[RequireComponent(typeof(Rigidbody2D))]
public class CharacterMovement : MonoBehaviour {

    

	public void Run(float speed)
	{
		transform.GetComponent<Rigidbody2D> ().AddForce (new Vector2(speed,0),ForceMode2D.Impulse);
	}

	public void ChangePos(float y)
	{

		Vector3 newpos = new Vector3(transform.position.x, y);
		transform.position = newpos;

	}


}
