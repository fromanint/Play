using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CharacterMovement))]
[RequireComponent(typeof(Animator))]
public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    float starTime;
	[SerializeField]
	float yOffset = -0.4f;
	[SerializeField] float speed;
	[SerializeField] float acceleration;


	CharacterMovement CM;
    // Use this for initialization
    void Start()
    {
        StartCoroutine("StartRun");
		CM = GetComponent<CharacterMovement> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
            if (hit)
            {
                if (hit.transform.tag == "Platform")
                {
					CM.ChangePos (hit.transform.position.y - yOffset);
                }
            }
        }


    }

	IEnumerator Acceleration()
	{
		yield return new WaitForSeconds (starTime);
		speed += acceleration;
		GetComponent<Animator> ().speed += acceleration;
		CM.Run (speed);
		StartCoroutine ("Acceleration");
	}


    IEnumerator StartRun()
    {
  
		yield return new WaitForSeconds (starTime);
        GetComponent<Animator>().SetTrigger("Run");
		CM.Run (speed);
		StartCoroutine ("Acceleration");
    }
}
