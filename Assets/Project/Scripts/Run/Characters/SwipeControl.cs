using UnityEngine;
using System.Collections;

[RequireComponent (typeof (PlayerControl))]
public class SwipeControl : MonoBehaviour {

    // Use this for initialization

	CharacterMovement CM;
	int index;
	
    private Vector2 lp; //primera posicion del dedo
    private Vector2 fp; // final de posicion del dedo

    void Start () {
		CM = transform.GetComponent<CharacterMovement> ();
        index = 0;
        CM.ChangePos(index);
	}

    // Update is called once per frame
    void FixedUpdate()
    {
       
        //Codigo Swipe
        foreach (Touch touch in Input.touches) {

            if (touch.phase == TouchPhase.Began) {
                fp = touch.position;
                lp = touch.position;
            }
            if (touch.phase == TouchPhase.Moved) {
                lp = touch.position;
            }

            if (touch.phase == TouchPhase.Ended) {

				
					if (lp.y>fp.y) { // up swipe
						Debug.Log ("up");
                         if (index < CM.yPosition.Length)
                         {
                              index++;
                         }
                      
					} else { // down swipe
						Debug.Log("down");
                        if (index >= 0)
                        { index--; }
						
					}
                CM.ChangePos(index);
				
  
            }
			
        }
	
       

      
        //Debug.Log ("horizontal " + h);
     

	}
}
