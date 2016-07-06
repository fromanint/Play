using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CharacterMovement))]
[RequireComponent(typeof(Animator))]
public class PlayerControl : MonoBehaviour
{
    public int lifes;

    [SerializeField]
    float starTime = 2f;
	[SerializeField]
	float yOffset = -0.4f;
	[SerializeField] float speed;
	[SerializeField] float acceleration = .05f;


	CharacterMovement CM;

	void Awake(){
		CM = GetComponent<CharacterMovement> ();

	}

    // Use this for initialization
    void Start()
    {
        StartCoroutine("StartRun");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity, 1 << LayerMask.NameToLayer("Platform"));
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
        if(Time.timeScale < 30)
        {
            CM.Run(acceleration);
            Time.timeScale = Time.timeScale + acceleration;
        }
        StartCoroutine ("Acceleration");
	}


    IEnumerator StartRun()
    {
  
		yield return new WaitForSeconds (starTime);
        GetComponent<Animator>().SetTrigger("Run");
		CM.Run (speed);
		StartCoroutine ("Acceleration");
        Time.timeScale = 1;
    }


	public void ManageLifes(){
		lifes--;
		if (lifes >= 0) {
			
			Debug.Log (lifes);
		} else {
			GetComponent<Animator> ().SetTrigger ("Fall");
			FindObjectOfType<UIGameControl> ().GameOver();
			Debug.Log ("Game Over");

		}
	
	}
   /* void OnTriggerEnter2D(Collider2D other)
    {
   
        if (other.gameObject.tag == "Obstacle")
        {
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            if (lifes > 0)
            {
                StartCoroutine("Obstacle", other.transform);

            }
            else {
                Time.timeScale = 0;
                Debug.Log("Game Over");
            }
        }
    }

    IEnumerator Obstacle(Transform obstacle)
    {
        Time.timeScale = 1;
        Debug.Log("Blinking");
        GetComponent<SpriteRenderer>().color = Color.Lerp(Color.white, Color.black, Mathf.PingPong(Time.time, 1));
        CM.Run(0);
        GetComponent<Animator>().SetTrigger("Hit");
        yield return new WaitForSeconds(starTime);
        Debug.Log(obstacle.gameObject.name);
       // Destroy(obstacle.gameObject);
        lifes--;
        StartCoroutine("StartRun");


    }*/


}
