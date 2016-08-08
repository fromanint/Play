using UnityEngine;
using System.Collections;

public class GuessFinish : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            FindObjectOfType<GuessControl> ().SaveScore();
        }
    }
}
