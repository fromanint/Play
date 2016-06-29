using UnityEngine;
using System.Collections;


public class BackgroundControl : MonoBehaviour {

    public bool mirror = false;
    [SerializeField] float offsetX;
    //GameObject Player;
    float next;
    Camera cam;
    bool hasnext;


	void Start()
	{
        cam = Camera.main;
      //  Player = GameObject.FindGameObjectWithTag("Player");
        next = GetComponent<SpriteRenderer>().bounds.size.x /2;
        hasnext = false;
      

    }
    void Update()
    {
        
       if (cam) {

            if (!hasnext)
            {
                float camHorizontalExtend = cam.orthographicSize * Screen.width / Screen.height;
                float edgeVisiblePositionRight = (transform.position.x + next) - camHorizontalExtend;
               
                if (cam.transform.position.x >= edgeVisiblePositionRight - offsetX && hasnext == false)
                {
                    Vector3 newPosition = new Vector3(transform.position.x + next*2, transform.position.y, transform.position.z);
                    Transform nextBg = Instantiate(transform, newPosition, transform.rotation) as Transform;
                    nextBg.SetParent(transform.parent);
                    nextBg.localScale = transform.localScale;
                    nextBg.GetComponent<SpriteRenderer>().flipX = mirror;
                    nextBg.GetComponent<BackgroundControl>().mirror = !mirror;
                    hasnext = true;
                }
            }
   
       }
        
      
    }



    }
