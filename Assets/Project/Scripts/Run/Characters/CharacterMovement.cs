using UnityEngine;
using System.Collections;


[RequireComponent(typeof(Rigidbody2D))]
public class CharacterMovement : MonoBehaviour {

    public Transform[] yPosition;
    


  
    [SerializeField]  float yOffset;

    public void Run(float speed)
	{
       // transform.GetComponent<Rigidbody2D> ().AddForce (new Vector2(speed,0),ForceMode2D.Impulse);
        transform.GetComponent<Rigidbody2D>().velocity = new Vector2(speed,0);
     
	}


	public void ChangePos(float y)
	{

		Vector3 newpos = new Vector3(transform.position.x, y+yOffset);
		transform.position = newpos;

	}

    public void ChangePos(int y)
    {
       
        Vector3 newpos = transform.position;
        newpos.y = yPosition[y].position.y + yOffset;
        transform.position = newpos;
       
    }


}
