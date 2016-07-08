using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CharacterMovement))]
[RequireComponent(typeof(Animator))]
public class PlayerControl : MonoBehaviour
{
    [HideInInspector]public int lifes;
    public int maxLifes;




    [SerializeField]
    float starTime = 2f;
	[SerializeField]
	float yOffset = -0.4f;
	[SerializeField] float startSpeed;
	[SerializeField] float acceleration = 1.05f;
    [SerializeField] float accelerationMilestone;
   
   [HideInInspector]
    public float speed;
    

	CharacterMovement CM;
  
    

	void Awake(){
		CM = GetComponent<CharacterMovement> ();
        speed = 0;
        lifes = maxLifes;
	}

    // Use this for initialization
    void Start()
    {
        accelerationMilestone += transform.position.x;
        StartCoroutine("StartRun");

    }



    // Update is called once per frame
    void Update()
    {

        if (transform.position.x >= accelerationMilestone)
        {
            speed *= acceleration;
            accelerationMilestone += transform.position.x;

        }
        CM.Run(speed);
    }


    IEnumerator StartRun()
    {
       
		yield return new WaitForSeconds (starTime);
        GetComponent<Animator>().SetTrigger("Run");
        speed = startSpeed;
		CM.Run (speed);
        
      
    }


	public void ManageLifes(float delay){
		lifes--;
		if (lifes >= 0) {
            GetComponent<Animator>().SetTrigger("Hit");
            FindObjectOfType<LifesManager>().UpdateLifes();
            speed = 0;
            CM.Run(speed);
            Start();

		} else {
            GetComponent<Animator>().SetTrigger("Fall");
            StartCoroutine("GameOver",delay);


		}
	
	}
    IEnumerator GameOver(float delay) {
        speed = 0;
        CM.Run(speed);
        
        FindObjectOfType<GameControl>().SaveScore();
        yield return new WaitForSeconds(delay+.05f);
        FindObjectOfType<UIGameControl>().GameOver();
    }



}
