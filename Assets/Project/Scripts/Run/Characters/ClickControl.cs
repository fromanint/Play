using UnityEngine;
using System.Collections;


[RequireComponent(typeof(PlayerControl))]
public class ClickControl : MonoBehaviour
{
    int index = 0;

    void Start()
    {
        GetComponent<CharacterMovement>().ChangePos(index);
    }
    void Update() { 
	    if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity, 1 << LayerMask.NameToLayer("Platform"));
            if (hit)
            {
                if (hit.transform.tag == "Platform")
                {

					GetComponent<CharacterMovement>().ChangePos (hit.transform.position.y);
                }
            }
        }
    }
}
