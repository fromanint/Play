using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CharacterMovement))]
[RequireComponent(typeof(Animator))]
public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    float starTime;
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
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
            if (hit)
            {
                if (hit.transform.tag == "Platform")
                {
                    Vector3 newpos = new Vector3(transform.position.x, hit.transform.position.y - 0.4f);
                    transform.position = newpos;
                    Debug.Log(hit.transform.name);
                }
            }

        }
    }

    IEnumerator StartRun()
    {
  
        yield return new WaitForSeconds(starTime);
  
        GetComponent<Animator>().SetTrigger("Run");
    }
}
