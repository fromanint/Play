using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GuessGameOver : MonoBehaviour {

    public Image[] stars;
    
    void OnEnable()
    {
       
        GuessControl gc = FindObjectOfType<GuessControl>();
        Debug.Log(gc.stars);
        if (gc.stars >= 0)
        {
            Debug.Log("Hola");
            for (int i = 0; i < gc.stars + 1; i++)
            {
                stars[i].gameObject.SetActive(true);
            }
        }
    }

}
